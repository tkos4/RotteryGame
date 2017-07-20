#region Using Statements

using System;
using System.Collections.Generic;
using System.IO;
using DrawGame.Client;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;
using DrawGame.Service;
using DrawGame.ViewModels;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace DrawGame
{
    public class Game1 : Game
    {
        #region Declerations

        #region Sql staff

        private WheelViewModel _wheelViewModel;
        

        private DrawService _calculateDraw = new DrawService();

        #endregion

        #region system

        private GameType _gameMode = GameType.Curtain;


        private readonly GraphicsDeviceManager _graphicsDeviceManager;
        private Rectangle _rendeRectangle;
        private RenderTarget2D _renderWheelTarget;
        private RenderTarget2D _renderEffectsTarget;

        private SpriteBatch _spriteBatch;
        private KeyboardState _keyboard;
        private MouseState _mouse;


        private bool _enterKeyBool;
        private bool _escapeKeybool;
        private bool _mousePressed;

        private TimeSpan _timer;
        private TimeSpan _pingTimer;


        #endregion

        #region General

        private Texture2D _connectingMsgTexture2D;
        private Texture2D _somethingWentWrongMsgTexture2D;
        private Rectangle _somethingWentWrongMsgRectangle;

        private Texture2D _backgroundTexture2D;
        private Rectangle _backgroundRectangle;

        private SpriteFont _winFrameFont;

        private Texture2D _lightsTexture2D;
        private Texture2D _winFrameTexture2D;
        private Rectangle _winFrameRectangle;

        private Texture2D _lostFrameTexture2D;
        private Rectangle _lostFrameRectangle;

        private Texture2D _giftTexture;
        private Rectangle _giftRectangle;

        private Texture2D _giftBigTexture;
        private Rectangle _giftBigrec;

        private readonly Texture2D[] _particlesTexture2Ds = new Texture2D[6];

        private ConnectionState _connectionState;

        #endregion

        #region curtain

        private Rectangle _curtaintRectangle;

        private Texture2D _curtainBoxTexture2D;

        private CurtainBox[] _curtainBoxes;

        private readonly Texture2D[] _curtainAnimationTexture2Ds = new Texture2D[11];
        private Texture2D _curtainBackgroundBackLayerTexture2D;
        private Texture2D _curtainBackgroundFrontLayerTexture2D;
        private Texture2D _boxCoverTexture2D;

        private bool _curtaintAnimationReady;
        private bool _curtainAnimationPlaying;

        private bool _delayOnCurtainWinFrame;

        private int _curtainAnimationCounter;
        private TimeSpan _curtainTimer;
        private int _curtainTimerLimit = 2;
        private SoundEffect _drumsSoundEffect;

        #endregion
        
        #region Wheel

        private Texture2D _wheelTexture2D;
        private Vector2 _wheelVector2;

        private Texture2D _pointerForWheelTexture2D;
        private Rectangle _pointerForRectangle;

        private Texture2D _wheelBackgroundTexture2D;

        private readonly Texture2D[] _wheelLedsTexture2Ds = new Texture2D[8];
        private TimeSpan _wheelLedsTimer;
        private int _wheelLedsCounter;
        private bool _wheelTimerRunning;

        #endregion

        #region Rotation variables

        private float _wheelRotation;
        private float _wheelRotationDestination;
        private float _speedOfRotation;

        private enum GameState
        {
            Rolling,
            Slowing,
            Ready,
            Idle
        };

        private GameState _gameState;

        #endregion

        #region Variables for the gifts

        private float _winningLightRotationLeft;
        private float _winningLightRotationRight;
        private float _winningLightSpeed = 0.01f;
        private readonly bool _winningLightsOn = Program.GamePreference.LighsOn;

        private readonly Particles[] _particles = new Particles[60];

        private string _winningTitle;


        private readonly List<GameItemRotation> _gameItemRotations = new List<GameItemRotation>();

        private readonly List<int> _lossingGamePart = new List<int>();
        private int _drawGamePartWinId;

        private bool _drawWin;
        private bool _drawLost;


        private Random _random;



        #endregion

        #region SoundEffect

        private SoundEffect _winSoundEffect;
        private SoundEffect _loseSoundEffect;
        private bool _soundOn = Program.GamePreference.SoundOn;

        #endregion

        #endregion

        public Game1()
        {

            _graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            _graphicsDeviceManager.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            _graphicsDeviceManager.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            // graphicsDeviceManager.IsFullScreen = true;

            _graphicsDeviceManager.ApplyChanges();
            


            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            
            base.Initialize();

            //2 render targets

            _renderWheelTarget = new RenderTarget2D(GraphicsDevice, 1366, 768);
            _renderEffectsTarget = new RenderTarget2D(GraphicsDevice, 1366, 768);
            if (_graphicsDeviceManager.PreferredBackBufferWidth > _graphicsDeviceManager.PreferredBackBufferHeight)
            {

                _rendeRectangle = new Rectangle(_graphicsDeviceManager.PreferredBackBufferWidth/2,_graphicsDeviceManager.PreferredBackBufferHeight/2
                    , _graphicsDeviceManager.PreferredBackBufferWidth,(int)(_graphicsDeviceManager.PreferredBackBufferWidth/(1366f/768f)));
            }
            else
            {
                _rendeRectangle = new Rectangle(_graphicsDeviceManager.PreferredBackBufferWidth/2,_graphicsDeviceManager.PreferredBackBufferHeight/2,
                    (int)(_graphicsDeviceManager.PreferredBackBufferHeight * (1366f / 768f)), _graphicsDeviceManager.PreferredBackBufferHeight);
            }

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // ------------change this later------------
            _wheelViewModel = GetWeelViewModel;
            //------------------------------------------

            #region GameMode read

            switch ((int) _wheelViewModel.Wheel.GameTypeId) //.GameType)
            {
                case 0:
                {
                    _gameMode = GameType.Wheel;
                    break;
                }
                case 1:
                {
                    _gameMode = GameType.Curtain;
                    break;
                }
            }



            #endregion

            #region GameMode initialize variables

            if (_gameMode == GameType.Curtain)
            {
                #region Curatain

                _boxCoverTexture2D = Content.Load<Texture2D>(@"boxcover");
                _curtainBoxTexture2D = Content.Load<Texture2D>(@"box");
                _curtainBackgroundBackLayerTexture2D = Content.Load<Texture2D>(@"backback");
                _curtainBackgroundFrontLayerTexture2D = Content.Load<Texture2D>(@"backfront");
                _drumsSoundEffect = Content.Load<SoundEffect>(@"drums");

                for (int i = 0; i < 11; i++)
                {
                    _curtainAnimationTexture2Ds[i] = Content.Load<Texture2D>((i + 1).ToString());
                }

                _curtaintRectangle = new Rectangle(0, 0, 1366, 768);

                _curtainBoxes = new CurtainBox[GetWeelViewModel.GameItems.Count];
                InitializeCurtainsBoxSize();


                #endregion
            }
            else if (_gameMode == GameType.Wheel)
            {
                #region Wheel 

                _wheelTexture2D = GetWeelViewModel.GetWheelTexture2D();



                _wheelVector2 = new Vector2(1366/2, 768/2);

                _pointerForWheelTexture2D = Content.Load<Texture2D>(@"pointer");
                _pointerForRectangle = new Rectangle(0, 0, _pointerForWheelTexture2D.Width,
                    _pointerForWheelTexture2D.Height);

                _wheelBackgroundTexture2D = Content.Load<Texture2D>(@"wheelback");

                for (int i = 0; i < _wheelLedsTexture2Ds.Length; i++)
                {
                    _wheelLedsTexture2Ds[i] = Content.Load<Texture2D>(@"light" + (i + 1));
                }



                #endregion

                #region initialize Wheel Rotation machanic

                float gameItemDegrees = (float)(Math.PI * 2) / _wheelViewModel.GameItems.Count;
                float gameItemDegreesCounter = 0;

                for (int i = 0; i < _wheelViewModel.GameItems.Count; i++)
                {
                    _gameItemRotations.Add(new GameItemRotation());
                    if (_wheelViewModel.GameItems[i].IsLoosingPie)
                    {
                        _lossingGamePart.Add(i);
                    }
                    _gameItemRotations[i].MakeStruct((gameItemDegreesCounter) + 0.05f,
                        (gameItemDegreesCounter + gameItemDegrees) - 0.05f);
                    gameItemDegreesCounter += gameItemDegrees;
                }


                _random = new Random(DateTime.Now.Second);

                #endregion
            }          

            #endregion

            #region General stuff

            _connectingMsgTexture2D = Content.Load<Texture2D>(@"connecting");
            _somethingWentWrongMsgTexture2D = Content.Load<Texture2D>(@"wrong");
            _somethingWentWrongMsgRectangle = new Rectangle(330, 250, _somethingWentWrongMsgTexture2D.Width,
                _somethingWentWrongMsgTexture2D.Height);

            _winFrameFont = Content.Load<SpriteFont>(@"WinFont");

            #region Read General Image From Sql 
            if (_wheelViewModel.Wheel.BackgroundImage != null)
            {
                using (Stream strm = new MemoryStream(_wheelViewModel.Wheel.BackgroundImage))
                {
                    _backgroundTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice, strm);
                }

            }
            else
            {
                _backgroundTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice,
                    File.OpenRead(@"Settings/back.png"));
            }
            _backgroundRectangle = new Rectangle(0, 0, 1366, 768);
            if (_wheelViewModel.Wheel.WinImage != null)
            {
                using (Stream strm = new MemoryStream(_wheelViewModel.Wheel.WinImage))
                {
                    _winFrameTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice, strm);
                }

            }
            else
            {
                _winFrameTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice,
                    File.OpenRead(@"Settings/win.png"));
            }
            _winFrameRectangle = new Rectangle(230, 50, 923, 659);

            if (_wheelViewModel.Wheel.LostImage != null)
            {
                using (Stream strm = new MemoryStream(_wheelViewModel.Wheel.LostImage))
                {
                    _lostFrameTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice, strm);
                }

            }
            else
            {
                _lostFrameTexture2D = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice,
                    File.OpenRead(@"Settings/lost.png"));
            }

            _lostFrameRectangle = new Rectangle(230, 50, 923, 659);
            #endregion

            #region Read WinSound and LoseSound and save it

            if (_wheelViewModel.Wheel.WinSound != null)
            {

                using (var file = new FileStream(@"Settings\temp.wav", FileMode.Create, FileAccess.Write))
                {
                    file.Write(_wheelViewModel.Wheel.WinSound, 0, _wheelViewModel.Wheel.WinSound.Length);
                }

                _winSoundEffect = new SoundEffect(File.ReadAllBytes(@"Settings\temp.wav"), 48000,AudioChannels.Stereo);

            }
            else
            {

                _winSoundEffect = new SoundEffect(File.ReadAllBytes(@"Settings/winsound.wav"), 48000,
                    AudioChannels.Stereo);
            }
            if (_wheelViewModel.Wheel.LostSound != null)
            {

                using (var file = new FileStream(@"Settings\temp.wav", FileMode.Create, FileAccess.Write))
                {
                    file.Write(_wheelViewModel.Wheel.LostSound, 0, _wheelViewModel.Wheel.LostSound.Length);
                }

                _loseSoundEffect = new SoundEffect(File.ReadAllBytes(@"Settings\temp.wav"), 48000,
                    AudioChannels.Stereo);

            }
            else
            {

                _loseSoundEffect = new SoundEffect(File.ReadAllBytes(@"Settings/LostSound.wav"), 48000,
                    AudioChannels.Stereo);
            }

            #endregion

            _lightsTexture2D = Content.Load<Texture2D>(@"lights");

            #region Particles different texture for different game modes

            if (Program.GamePreference.ParticlesStyle == ParticlesStyle.Confetti)
            {
                _particlesTexture2Ds[0] = Content.Load<Texture2D>(@"pixi1");
                _particlesTexture2Ds[1] = Content.Load<Texture2D>(@"pixi5");
                _particlesTexture2Ds[2] = Content.Load<Texture2D>(@"pixi6");
                _particlesTexture2Ds[3] = Content.Load<Texture2D>(@"pixi4");
                _particlesTexture2Ds[4] = Content.Load<Texture2D>(@"pixi3");
                _particlesTexture2Ds[5] = Content.Load<Texture2D>(@"pixi2");
            }
            else if (Program.GamePreference.ParticlesStyle == ParticlesStyle.CoffeeBeans)
            {
                _particlesTexture2Ds[0] = Content.Load<Texture2D>(@"an1");
                _particlesTexture2Ds[1] = Content.Load<Texture2D>(@"an5");
                _particlesTexture2Ds[2] = Content.Load<Texture2D>(@"an6");
                _particlesTexture2Ds[3] = Content.Load<Texture2D>(@"an4");
                _particlesTexture2Ds[4] = Content.Load<Texture2D>(@"an3");
                _particlesTexture2Ds[5] = Content.Load<Texture2D>(@"an2");
            }
            else if (Program.GamePreference.ParticlesStyle == ParticlesStyle.Snow)
            {
                _particlesTexture2Ds[0] = Content.Load<Texture2D>(@"sn1");
                _particlesTexture2Ds[1] = Content.Load<Texture2D>(@"sn5");
                _particlesTexture2Ds[2] = Content.Load<Texture2D>(@"sn6");
                _particlesTexture2Ds[3] = Content.Load<Texture2D>(@"sn4");
                _particlesTexture2Ds[4] = Content.Load<Texture2D>(@"sn3");
                _particlesTexture2Ds[5] = Content.Load<Texture2D>(@"sn2");
            }

            #endregion

            _giftRectangle = new Rectangle(_winFrameRectangle.X + 400, _winFrameRectangle.Y + 368, 125, 125);
            _giftBigrec = new Rectangle(1366 / 2, 600, 400, 400);            

            _speedOfRotation = 0.1f;
            _gameState = GameState.Ready;
            _drawLost = false;
            _drawWin = false;

            #endregion

            #region Connection status

            _connectionState = _calculateDraw.Connection.State;
            _calculateDraw.Connection.StateChanged += Connection_StateChanged;

            #endregion
            
            #region Particle System

            for (int i = 0; i < 60; i++)
            {

                _particles[i] = new Particles(_particlesTexture2Ds, i);

            }

            #endregion

        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {

            #region System

            _mouse = Mouse.GetState();
            _keyboard = Keyboard.GetState();

            if (_connectionState == ConnectionState.Reconnecting || _connectionState == ConnectionState.Disconnected)
            {
                #region Reconnect

                _pingTimer += gameTime.ElapsedGameTime;
                if (_pingTimer.Seconds > 15)
                {
                    _pingTimer = TimeSpan.Zero;
                    _calculateDraw = new DrawService();
                    _connectionState = _calculateDraw.Connection.State;
                    _calculateDraw.Connection.StateChanged += Connection_StateChanged;

                }

                #endregion
            }

            #endregion

            if (_gameMode == GameType.Curtain)
            {
                #region Curtain mechanic

                if (!_curtainAnimationPlaying)
                {
                    #region Curtains update

                    if (_connectionState == ConnectionState.Connected)
                    {
                        foreach (var box in _curtainBoxes)
                        {
                            box.Update(_mouse);
                            if (box.Click)
                            {
                                MakeDraw();

                                _curtaintAnimationReady = false;
                                _curtainAnimationPlaying = true;


                                box.Click = false;
                                _curtainTimer = TimeSpan.Zero;
                                _gameState = GameState.Idle;

                                #region After Draw calculate Win images and time

                                if (_drawWin)
                                {
                                    _curtainTimerLimit = 20;
                                    _drumsSoundEffect.Play();
                                    _giftBigTexture = _wheelViewModel.GameItems[_drawGamePartWinId].ImageOriginal;
                                    if (_giftBigTexture.Width < 400 || _giftBigTexture.Height < 400)
                                    {
                                        #region Small resolution

                                        if (_giftBigTexture.Width > _giftBigTexture.Height)
                                        {

                                            _giftBigrec.Width = 300;
                                            _giftBigrec.Height =
                                                (int) (300f/_giftBigTexture.Width*_giftBigTexture.Height);
                                        }
                                        else
                                        {
                                            _giftBigrec.Height = 300;
                                            _giftBigrec.Width =
                                                (int) (300f/_giftBigTexture.Height*_giftBigTexture.Width);

                                        }

                                        #endregion
                                    }
                                    else
                                    {
                                        #region Big resolution

                                        if (_giftBigTexture.Width > _giftBigTexture.Height)
                                        {

                                            _giftBigrec.Width = 400;
                                            _giftBigrec.Height =
                                                (int) (400f/_giftBigTexture.Width*_giftBigTexture.Height);
                                        }
                                        else
                                        {
                                            _giftBigrec.Height = 400;
                                            _giftBigrec.Width =
                                                (int) (400f/_giftBigTexture.Height*_giftBigTexture.Width);

                                        }

                                        #endregion
                                    }

                                }
                                else
                                {
                                    _curtainTimerLimit = 2;
                                }

                                #endregion

                            }
                        }
                    }

                    #endregion
                }

                #region animation

                #region Curtain animation open

                if (!_curtaintAnimationReady && _curtainAnimationPlaying)
                {
                    _curtainTimer += gameTime.ElapsedGameTime;
                    if (!_delayOnCurtainWinFrame)
                    {
                        if (_curtainTimer.Milliseconds > 120)
                        {
                            _curtainTimer = TimeSpan.Zero;
                            _curtainAnimationCounter++;
                        }
                        if (_curtainAnimationCounter == 10)
                        {
                            _curtainTimer = TimeSpan.Zero;
                            if (_drawWin)
                            {
                                _delayOnCurtainWinFrame = true;


                            }
                            else
                            {
                                _delayOnCurtainWinFrame = false;
                                _curtaintAnimationReady = true;
                                _gameState = GameState.Ready;
                                AfterDraw();
                            }
                        }
                    }
                    if (_delayOnCurtainWinFrame && _curtainTimer.Milliseconds > 300)
                    {
                        _delayOnCurtainWinFrame = false;
                        _curtaintAnimationReady = true;
                        _curtainTimer = TimeSpan.Zero;
                        _gameState = GameState.Ready;
                        AfterDraw();
                    }
                }

                #endregion

                #region Reset to game after _curtainTimerLimit(Seconds)

                if (_curtaintAnimationReady && _curtainAnimationPlaying)
                {
                    _curtainTimer += gameTime.ElapsedGameTime;
                    if (_curtainTimer.Seconds > _curtainTimerLimit)
                    {
                        ResetCurtainAfterDraw();
                    }
                }

                #endregion

                #endregion

                #region Reset with Click

                if (_curtainAnimationPlaying)
                {
                    if (_mouse.LeftButton == ButtonState.Pressed)
                    {
                        _mousePressed = true;

                    }
                    if (_mousePressed && _mouse.LeftButton == ButtonState.Released)
                    {
                        _mousePressed = false;
                        ResetCurtainAfterDraw();
                    }
                }

                #endregion


                #endregion

            }
            else if (_gameMode == GameType.Wheel)
            {

                #region Win or Lose timers

                if (_wheelTimerRunning)
                {
                    _timer += gameTime.ElapsedGameTime;

                }
                if (_drawWin && _timer.Seconds > 20)
                {
                    _wheelTimerRunning = false;
                    _timer = TimeSpan.Zero;
                    _drawLost = false;
                    _drawWin = false;
                }
                if (_drawLost && _timer.Seconds > 2)
                {
                    _timer = TimeSpan.Zero;
                    _drawLost = false;
                    _wheelTimerRunning = false;
                }

                #endregion

                #region Wheel mechanic

                #region animation lights on wheel

                _wheelLedsTimer += gameTime.ElapsedGameTime;
                if (_wheelLedsTimer.Milliseconds > 400)
                {
                    _wheelLedsTimer = TimeSpan.Zero;
                    _wheelLedsCounter++;
                    if (_wheelLedsCounter > 7)
                    {
                        _wheelLedsCounter = 0;
                    }

                }

                #endregion

                if (_gameState == GameState.Ready)
                {
                    if (_connectionState == ConnectionState.Connected)
                    {
                        #region Idle wheel

                        //if (_mouse.LeftButton == ButtonState.Pressed)
                        //{
                        //    _enterKeyBool = true;
                        //}

                        if (_keyboard.IsKeyDown(Keys.Enter))
                        {
                            _enterKeyBool = true;

                        }
                        if (_enterKeyBool && _keyboard.IsKeyUp(Keys.Enter))
                        {
                            _enterKeyBool = false;
                            _drawLost = false;
                            _drawWin = false;
                            MakeDraw();
                            _wheelRotation = 0f;
                            _wheelRotationDestination = CalculateWhereRotationStop(2);

                            _gameState = GameState.Rolling;


                        }

                        #endregion
                    }
                }
                else
                {
                    #region Rotation Logic

                    if (_gameState == GameState.Rolling && _wheelRotation + 6f < _wheelRotationDestination)
                    {
                        _wheelRotation += _speedOfRotation;

                    }
                    else if (_gameState == GameState.Rolling)
                    {
                        _gameState = GameState.Slowing;

                    }
                    if (_gameState == GameState.Slowing && _wheelRotation < _wheelRotationDestination)
                    {
                        if (_speedOfRotation >= 0.01f)
                        {
                            _speedOfRotation -= 0.001f;
                        }
                        _wheelRotation += _speedOfRotation;

                    }
                    else if (_gameState == GameState.Slowing)
                    {
                        _wheelTimerRunning = true;
                        _gameState = GameState.Ready;
                        _speedOfRotation = 0.1f;

                        AfterDraw();
                    }

                    #endregion
                }

                #endregion
            }


            //   FOR TEST ONLY  //
            if (_keyboard.IsKeyDown(Keys.T))
            {
                MakeDraw();
                AfterDraw();
            }
            //  --------------  //

            #region Win animations (particles and lights)

            if ((_gameState == GameState.Ready) && _drawWin)
            {
                foreach (var parit in _particles)
                {
                    parit.Update(gameTime);
                }
                if (_winningLightsOn)
                {
                    if (_winningLightRotationLeft >= -0.379466f && _winningLightRotationLeft < 0.26616f)
                    {
                        _winningLightRotationLeft += _winningLightSpeed;
                        _winningLightRotationRight -= _winningLightSpeed;
                    }
                    else
                    {
                        _winningLightSpeed = -_winningLightSpeed;
                        _winningLightRotationLeft += _winningLightSpeed;
                        _winningLightRotationRight -= _winningLightSpeed;
                    }
                }

            }


            #endregion

            #region Close game

            if (_keyboard.IsKeyDown(Keys.Escape))
            {
                _escapeKeybool = true;
            }
            if (_escapeKeybool && _keyboard.IsKeyUp(Keys.Escape))
            {
                _escapeKeybool = false;
                Exit();
            }
            if (_calculateDraw.Restart)
            {
                Exit();
            }

            #endregion

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            #region Render effects

            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(_renderEffectsTarget);
            GraphicsDevice.Clear(Color.Transparent);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_backgroundTexture2D,_backgroundRectangle,Color.White);
            if (_gameMode == GameType.Curtain)
            {
                #region Curtain 

                if (_curtainAnimationPlaying)
                {
                    _spriteBatch.Draw(_curtainBackgroundBackLayerTexture2D, _curtaintRectangle, Color.White);
                    if (_drawWin)
                    {
                        _spriteBatch.Draw(_giftBigTexture, _giftBigrec, null, Color.White, 0f,
                            new Vector2(_giftBigTexture.Width/2f, _giftBigTexture.Height/2f), SpriteEffects.None, 0f);
                    }
                    _spriteBatch.Draw(_curtainAnimationTexture2Ds[_curtainAnimationCounter], _curtaintRectangle,
                        Color.White);
                    _spriteBatch.Draw(_curtainBackgroundFrontLayerTexture2D, _curtaintRectangle, Color.White);
                }



                #endregion
            }
            #region Win Effect
            if (_gameState == GameState.Ready && _drawWin)
            {
                _spriteBatch.Draw(_backgroundTexture2D, _backgroundRectangle, Color.Black * 0.4f);
                foreach (var parit in _particles)
                {
                    parit.Draw(_spriteBatch);
                }
                if (_winningLightsOn)
                {
                    _spriteBatch.Draw(_lightsTexture2D, new Vector2(34, 690), null, Color.White,_winningLightRotationLeft,
                        new Vector2(25, 893), 1f, SpriteEffects.None, 0f);
                    _spriteBatch.Draw(_lightsTexture2D, new Vector2(1334, 690), null, Color.White,_winningLightRotationRight,
                        new Vector2(1517, 893), 1f, SpriteEffects.FlipHorizontally, 0f);
                }

            }
            #endregion
            if (_drawLost)
            {
                _spriteBatch.Draw(_backgroundTexture2D, _backgroundRectangle, Color.Black * 0.4f);
            }
            _spriteBatch.End();
            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(null);
            #endregion

            #region Render Wheel


            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(_renderWheelTarget);
            GraphicsDevice.Clear(Color.Transparent);

            _spriteBatch.Begin();
            if (_gameMode == GameType.Wheel)
            {
                #region Wheel Draw


                _spriteBatch.Draw(_wheelBackgroundTexture2D, _wheelVector2, null, Color.White, 0f,
                    new Vector2(_wheelBackgroundTexture2D.Width/2f, _wheelBackgroundTexture2D.Height/2f), 1f,
                    SpriteEffects.None, 0f);
                _spriteBatch.Draw(_wheelTexture2D, _wheelVector2, null, Color.White, _wheelRotation,
                    new Vector2(_wheelTexture2D.Width/2f, _wheelTexture2D.Height/2f), 1f, SpriteEffects.None, 0f);

                _spriteBatch.Draw(_pointerForWheelTexture2D, _pointerForRectangle, Color.White);
                _spriteBatch.Draw(_wheelLedsTexture2Ds[_wheelLedsCounter], _wheelVector2, null, Color.White, 0f,
                    new Vector2(_wheelBackgroundTexture2D.Width/2f, _wheelBackgroundTexture2D.Height/2f), 1f,
                    SpriteEffects.None, 0f);



                #endregion
            }          
            #region Win and Lose Draw

            if (_gameState == GameState.Ready && _drawWin)
            {               
                _spriteBatch.Draw(_winFrameTexture2D, _winFrameRectangle, Color.White);
                _spriteBatch.Draw(_giftTexture, _giftRectangle, Color.White);
                _spriteBatch.DrawString(_winFrameFont, _winningTitle, new Vector2(1366/2, 315), Color.Black, 0f,
                    new Vector2(_winFrameFont.MeasureString(_winningTitle).X/2, 0), 1f, SpriteEffects.None, 0f);

            }
            if (_drawLost)
            {

                _spriteBatch.Draw(_lostFrameTexture2D, _lostFrameRectangle, Color.White);
            }

            #endregion
            #region Connection messages
            if (_connectionState != ConnectionState.Connected)
            {
                GraphicsDevice.Clear(Color.Transparent);


                if (_connectionState == ConnectionState.Disconnected)
                {
                    _spriteBatch.Draw(_somethingWentWrongMsgTexture2D, _somethingWentWrongMsgRectangle, Color.White);
                }
                else if (_connectionState == ConnectionState.Connecting ||
                         _connectionState == ConnectionState.Reconnecting)
                {
                    _spriteBatch.Draw(_connectingMsgTexture2D, _somethingWentWrongMsgRectangle, Color.White);
                }
            }
            #endregion
            _spriteBatch.End();

            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(null);

            #endregion

            #region Noraml Draw

            _spriteBatch.Begin();

            _spriteBatch.Draw(_renderEffectsTarget, new Rectangle(0, 0, _graphicsDeviceManager.PreferredBackBufferWidth,_graphicsDeviceManager.PreferredBackBufferHeight), Color.White);
            

            if (_gameMode == GameType.Wheel)
            {
                _spriteBatch.Draw(_renderWheelTarget, _rendeRectangle, null, Color.White, 0f,new Vector2(_renderWheelTarget.Width/2f, _renderWheelTarget.Height/2f), SpriteEffects.None, 0f);

            }
            else if (_gameMode == GameType.Curtain)
            {
                #region Curtain draw
                if (!_curtainAnimationPlaying)
                {

                    _spriteBatch.Draw(_renderWheelTarget,
                        new Rectangle(0, 0, _graphicsDeviceManager.PreferredBackBufferWidth,
                            _graphicsDeviceManager.PreferredBackBufferHeight), Color.White);
                    foreach (var dem in _curtainBoxes)
                    {
                        dem.Draw(_spriteBatch);
                    }
                    if (_connectionState != ConnectionState.Connected)
                    {

                        _spriteBatch.Draw(_renderWheelTarget,
                            new Rectangle(0, 0, _graphicsDeviceManager.PreferredBackBufferWidth,
                                _graphicsDeviceManager.PreferredBackBufferHeight), Color.White);

                    }

                }
                else if (_curtainAnimationPlaying)
                {

                    
                    _spriteBatch.Draw(_renderWheelTarget,
                        new Rectangle(0, 0, _graphicsDeviceManager.PreferredBackBufferWidth,
                            _graphicsDeviceManager.PreferredBackBufferHeight), Color.White);
                }
                #endregion
            }

            _spriteBatch.End();

            #endregion

            base.Draw(gameTime);
        }

        #region Draw Methods
        public bool MakeDraw()
        {

            _calculateDraw.SentRequest(_wheelViewModel.Wheel.GameId);
            var takeStatus = _calculateDraw.DrawResponse;
            
            while(true)
            {                

                if (_calculateDraw.Response)
                {                  
                    takeStatus = _calculateDraw.DrawResponse;
                    break;
                }
            }
            
            if (takeStatus != null)
            {
                _drawWin = takeStatus.Win;
                _drawGamePartWinId = takeStatus.WinnerId;
            }
            else
            {
                //_connectionState=ConnectionState.Disconnected;                
                _drawWin = false;
                _drawGamePartWinId = 0;
                return false;
            }
            _calculateDraw.Response = false;
            WheelDrawSaveStatistics();
            _calculateDraw.DrawResponse = null;
            return _drawWin;

        }

        public void AfterDraw()
        {
            if (!_drawWin)
            {
                _drawLost = true;
                _timer = TimeSpan.Zero;
                if (_soundOn)
                {
                    _loseSoundEffect.Play();
                }
            }
            else
            {
                _giftTexture = _wheelViewModel.GameItems[_drawGamePartWinId].ImageOriginal;
                if (_giftTexture.Width > _giftTexture.Height)
                {
                    _giftRectangle.X = _winFrameRectangle.X + 400;
                    _giftRectangle.Width = 125;
                    _giftRectangle.Height = (int)(125f / _giftTexture.Width * _giftTexture.Height);
                }
                else
                {
                    _giftRectangle.Height = 125;
                    _giftRectangle.Width = (int)(125f / _giftTexture.Height * _giftTexture.Width);
                    _giftRectangle.X = _winFrameRectangle.X + 400 + (63 - _giftRectangle.Width / 2);
                }
                if (_soundOn)
                {
                    _winSoundEffect.Play();
                }
                _winningTitle = _wheelViewModel.GameItems[_drawGamePartWinId].WinningTitle;


            }
        }

        public void WheelDrawSaveStatistics()
        {

            var wheelDraw = new Draw
            {
                OrderLineId = System.Net.Dns.GetHostName(),
                BranchId = 1,
                OrderLineQuantityIndex = 1,
                ProductCode = _wheelViewModel.GameItems[_drawGamePartWinId].ProductCode,
                WheelDrawDateTime = DateTime.Now,
                Wins = _drawWin,
                GameType =(GameType)_wheelViewModel.Wheel.GameTypeId,
                GameId = _wheelViewModel.Wheel.GameId
            };
           // _wheelViewModel.UpdateStatistics(wheelDraw);

        }

        #endregion            

        #region Curtain Methods
        public void InitializeCurtainsBoxSize()
        {

            var screenHeight = _graphicsDeviceManager.PreferredBackBufferHeight;
            var screenWidth = _graphicsDeviceManager.PreferredBackBufferWidth;

            var dimentions = CalculateCurtainBoxDimentions(_curtainBoxes.Length);

            var collum = (int) dimentions.X;
            var row = (int) dimentions.Y;
            var heigth = (int) (screenHeight/(collum + 1f));
            var width = (int) (screenWidth/(row + 1f));
            var y = (int) (((768f/collum)/768f)*screenHeight);
            var x = (int) (((1366f/row)/1366f)*screenWidth);

            var collumCounter = 0;
            var rowCounter = 0;

            for (int i = 0; i < _curtainBoxes.Length; i++)
            {
                var currentRectangle = new Rectangle(0, 0, 1366, 768);
                if (rowCounter < row)
                {

                    currentRectangle.X = x*rowCounter;
                    currentRectangle.X = currentRectangle.X + width/6;
                    rowCounter++;
                }
                else
                {
                    rowCounter = 0;
                    collumCounter++;
                    currentRectangle.X = x*rowCounter;
                    currentRectangle.X = currentRectangle.X + width/6;
                    rowCounter++;
                }

                currentRectangle.Y = y*collumCounter;
                currentRectangle.Y = currentRectangle.Y + heigth/6;
                currentRectangle.Width = width;
                currentRectangle.Height = heigth;


                _curtainBoxes[i] = new CurtainBox(_curtainBoxTexture2D, currentRectangle, _boxCoverTexture2D);
            }




        }

        public Vector2 CalculateCurtainBoxDimentions(int numberOfCurtainBoxes)
        {
            int fixedRange;

            if (numberOfCurtainBoxes <= 4)
            {
                fixedRange = 3;
            }           
            else if (numberOfCurtainBoxes > 4 && numberOfCurtainBoxes <= 9)
            {
                fixedRange = 4;
            }
            else if (numberOfCurtainBoxes > 9 && numberOfCurtainBoxes <= 16)
            {
                fixedRange = 5;
            }
            else if (numberOfCurtainBoxes > 16 && numberOfCurtainBoxes <= 25)
            {
                fixedRange = 6;
            }
            else
            {
                fixedRange = 9;
            }


            for (int i = 0; i < fixedRange; i++)
            {
                for (int j = 0; j < fixedRange; j++)
                {
                    if (i*j == numberOfCurtainBoxes)
                    {
                        return new Vector2(i, j);
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < fixedRange; j++)
                {
                    if (j*i > numberOfCurtainBoxes)
                    {
                        return new Vector2(j, i);
                    }
                }
            }


            return new Vector2();

        }

        public void ResetCurtainAfterDraw()
        {
            _curtainTimer = TimeSpan.Zero;
            _gameState = GameState.Ready;
            _curtainAnimationCounter = 0;
            _drawLost = false;
            _curtaintAnimationReady = false;
            _curtainAnimationPlaying = false;
            _drawWin = false;
        }

        #endregion

        #region Wheel Methods
        public float CalculateWhereRotationStop(int second)
        {
            var rotationSecond = (float)((2 * Math.PI) * second);
            float temp;
            if (_drawWin)
            {
                temp = _gameItemRotations[_drawGamePartWinId].RotationStop();
                return temp + rotationSecond;
            }
            var test = _lossingGamePart[_random.Next(0, _lossingGamePart.Count)];
            temp = _gameItemRotations[test].RotationStop();
            return temp + rotationSecond;

        }

        #endregion

        public WheelViewModel GetWeelViewModel
        {
            get
            {
                if (_wheelViewModel == null)
                {
                    var hostname = "";
                    if (File.Exists("connectionString.cfg"))
                    {
                        hostname = File.ReadAllText("connectionString.cfg");
                    }
                    var wheelRepository = new GameRepository(hostname);

                    var wheelObject = wheelRepository.GetWizDrawGameById2(Program.GamePreference.GameId);

                    var wheelService = new WheelService();

                    _wheelViewModel = new WheelViewModel(wheelObject, _graphicsDeviceManager, Content, wheelService,
                        _spriteBatch);


                }
                return _wheelViewModel;
            }

        }

        private void Connection_StateChanged(StateChange obj)
        {
            if (_calculateDraw.Connection.State != ConnectionState.Connecting)
            {
                _connectionState = _calculateDraw.Connection.State;
                if (_calculateDraw.Connection.State == ConnectionState.Disconnected || _calculateDraw.Connection.State == ConnectionState.Reconnecting)
                {
                    _pingTimer = TimeSpan.Zero;
                }
            }

        }

    }
}
