using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using DrawGame.Domain.Model.Core;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;
using DrawGame.Service;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DrawGame.ViewModels
{
    public class WheelViewModel : NotificationObject
    {
        #region Members

        private WheelService _wheelService;

        private WizDrawGame _wheel;

        private readonly GraphicsDeviceManager _graphicsDeviceManager;
        
        private readonly ContentManager _contentManager;

        private readonly SpriteBatch _spriteBatch;

        private readonly BindingList<GameItemViewModel> _GameItems;

        private Texture2D _wheelTexture2D;


        #endregion

        #region Constructor
        public WheelViewModel(WizDrawGame wheel, GraphicsDeviceManager graphicsDeviceManager, ContentManager contentManager, WheelService wheelService, SpriteBatch spriteBatch)
        {
            _wheel = wheel;
            
            _graphicsDeviceManager = graphicsDeviceManager;
            
            _contentManager= contentManager;

            _wheelService = wheelService;

            _spriteBatch = spriteBatch;

            _GameItems= new BindingList<GameItemViewModel>();

            foreach (var GameItemViewModel in _wheel.GameItems.Select(GameItem => new GameItemViewModel(GameItem)).Where(GameItemViewModel => GameItemViewModel.IsActive))
            {
                _GameItems.Add(GameItemViewModel);
            }
            foreach (GameItemViewModel GameItemViewModel in _GameItems)
            {
                SetWheelImageFromFile( GameItemViewModel, _GameItems.Count);
            }
        }

        #endregion

        #region Properties

        public WizDrawGame Wheel
        {
            get { return _wheel; }
            set { _wheel = value; }
        }
        public BindingList<GameItemViewModel> GameItems
        {
            get { return _GameItems; }
        }
        public int LoosingPieCount
        {
            get { return GameItems.Count(p => p.IsActive && p.IsLoosingPie); }
        }
        public int ProductPieCount
        {
            get { return GameItems.Count(p => p.IsActive && p.IsLoosingPie == false); }
        }
        public Texture2D GetWheelTexture2D()
        {

            if (_wheelTexture2D == null)
            {
                CreateWheelTexture2D();
            }

            return _wheelTexture2D;
        }      

        #endregion

        #region Methods

        public void CreateWheelTexture2D()
        {
            var pieSum = GameItems.Count;
            #region Local Temp Variables

            const int sumline = 5000;

            SpriteFont spriteForPie;

            const float angleAdder = (float)(2 * Math.PI) / sumline;
            float radius = 0;

            var line = new Lines[sumline];
            

            var colorIndex = (double)sumline / (double)pieSum;
            var colorchanger = colorIndex;
            var colorCounter = 0;


            var image = new Images[pieSum];
            float angleImage = (float)(2 * Math.PI) / pieSum;
            float angleCounter = 0f;

            #endregion

            #region Read Install items
            var sample = _contentManager.Load<Texture2D>(@"line");
            var effeTex = _contentManager.Load<Texture2D>(@"effe");
            //Calculate the font that i use
            if (pieSum >= 13 && pieSum <15)
            {
                spriteForPie = _contentManager.Load<SpriteFont>(@"aria13");
            }
            else if (pieSum >= 15)
            {
                spriteForPie = _contentManager.Load<SpriteFont>(@"aria16");
            }
            else
            {
                spriteForPie = _contentManager.Load<SpriteFont>(@"arial");
            }
            //
            #endregion
         
            #region Image creator

            var effeRec = new Rectangle(0, 0, effeTex.Width, effeTex.Height);
            var newCicleTex = new Texture2D(_graphicsDeviceManager.GraphicsDevice, sample.Height * 2, sample.Height * 2);
            var render = new RenderTarget2D(_graphicsDeviceManager.GraphicsDevice, sample.Height * 2, sample.Height * 2);

            for (int i = 0; i < sumline; i++)
            {
                line[i] = new Lines(sample, radius, _GameItems[colorCounter].GameItemBackColor1);
                radius -= angleAdder;
                if (colorchanger < i)
                {
                    colorchanger += colorIndex;
                    colorCounter++;
                }

            }            
            for (int i = 0; i < pieSum; i++)
            {
                angleCounter -= angleImage;              
                image[i] = new Images(sample, GameItems[i].Image, angleCounter + angleImage/2, spriteForPie,GameItems[i].Caption);

            }

            

            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(render);
            _graphicsDeviceManager.GraphicsDevice.Clear(Color.Transparent);            
            _spriteBatch.Begin();


            for (int i = 0; i < line.Count(); i++)
            {
                line[i].Draw(_spriteBatch);
            }
            _spriteBatch.Draw(effeTex, effeRec, Color.White);
            for (int i = 0; i < pieSum; i++)
            {
                image[i].Draw(_spriteBatch);
            }

            _spriteBatch.End();
            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(null);

            #endregion

            #region Save the image
            var data = new Color[sample.Height * 2 * sample.Height * 2];
            render.GetData<Color>(data);
            newCicleTex.SetData<Color>(data);
            _wheelTexture2D = newCicleTex;
            #endregion
        }       

        public void Spin(string code)
        {
            if (ValidateCode(code)==false)
            {
                //Draw Loose
                PresentBadOrUsedCode();
                return;
            }           

        }

        private void PresentBadOrUsedCode()
        {
            
        }

        private void PresentWin()
        {
            
        }

        private Boolean ValidateCode(string code)
        {
            return _wheelService.CheckCodeIsValid(code);
        }               

        public void UpdateStatistics(Draw wheelDraw)
        {
            _wheelService.GetStatistics().InsertWheelDraw(wheelDraw);
        }
       
        /// <summary>
        /// Resize Image to fit the Wheel
        /// </summary>
        /// <param name="graphicsDevice"></param>
        /// <param name="GameItem"></param>
        /// <param name="GameItemCount"></param>
        /// <returns></returns>
        public void SetWheelImageFromFile( GameItemViewModel GameItem, int GameItemCount)
        {
            
            Stream strm = new MemoryStream(GameItem.ImagePath);
            GameItem.ImageOriginal = Texture2D.FromStream(_graphicsDeviceManager.GraphicsDevice, strm);

            int smallImageSize = GetSizeDividerByTotalPieCount(GameItemCount) / (GameItemCount * 2);

            #region Resize image

            var bigWidth = (int)(((float)GameItem.ImageOriginal.Width / GameItem.ImageOriginal.Height) * smallImageSize);
            var bigHeight = (int)(((float)GameItem.ImageOriginal.Height / GameItem.ImageOriginal.Width) * smallImageSize);


            var render = new RenderTarget2D(_graphicsDeviceManager.GraphicsDevice, smallImageSize, smallImageSize);
            var spriteBatch = new SpriteBatch(_graphicsDeviceManager.GraphicsDevice);
            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(render);
            _graphicsDeviceManager.GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin();
            if (GameItem.ImageOriginal.Width > GameItem.ImageOriginal.Height)
            {
                spriteBatch.Draw(GameItem.ImageOriginal,
                    new Rectangle(0, (smallImageSize - bigHeight) / 2, smallImageSize, bigHeight), Color.White);
            }
            else
            {
                spriteBatch.Draw(GameItem.ImageOriginal,
                    new Rectangle((smallImageSize - bigWidth) / 2, 0, bigWidth, smallImageSize), Color.White);
            }
            spriteBatch.End();
            _graphicsDeviceManager.GraphicsDevice.SetRenderTarget(null);
            GameItem.Image = render;

            #endregion

        }
      
        /// <summary>
        /// Sets the divider of image from Wheel
        /// </summary>
        /// <param name="GameItemCount"></param>
        /// <returns></returns>
        public int GetSizeDividerByTotalPieCount(int GameItemCount)
        {

            int sizeDividerByTotalPieCount = 1000;

            if(GameItemCount < 1)
            {
                sizeDividerByTotalPieCount = 2000;
                return sizeDividerByTotalPieCount;
            }
            if (GameItemCount >= 1 && GameItemCount <= 3)
            {
                sizeDividerByTotalPieCount = 1000;
                return sizeDividerByTotalPieCount;
            }
            if (GameItemCount >= 4 && GameItemCount <= 5)
            {
                sizeDividerByTotalPieCount = 1500;
                return sizeDividerByTotalPieCount;
            }
            
            if (GameItemCount > 5 && GameItemCount <= 9)
            {
                sizeDividerByTotalPieCount = 1700;
                return sizeDividerByTotalPieCount;
            }
            if (GameItemCount > 9 )//&&  GameItemCount <= 16)
            {
                sizeDividerByTotalPieCount = 2000;
                return sizeDividerByTotalPieCount;
                //sumline = 4500;
            }
            

            return sizeDividerByTotalPieCount;

        }

        #endregion


    }
}
