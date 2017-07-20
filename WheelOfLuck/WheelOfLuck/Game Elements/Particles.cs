using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DrawGame
{
    class Particles
    {
        
        private readonly Texture2D[] _particleFramesTexture2Ds=new Texture2D[6];
        private Rectangle _particleRectangle;
        private static Random _random;
        private int _left, _right;
        private int _counter;
        private TimeSpan _timer;
               

        public Particles(Texture2D[] textures,int randomSeed )
        {
            

            _random = new Random(randomSeed);
            _particleFramesTexture2Ds = textures;
            _counter = _random.Next(0, 6);
            _particleRectangle = new Rectangle(_random.Next(0, 1366), _random.Next(0, 768), _particleFramesTexture2Ds[0].Width, _particleFramesTexture2Ds[0].Height);
            if (_random.Next(1, 3) == 1)
            {
                _left = 10;
                _right = 0;
            }
            else
            {
                _left = 0;
                _right = 10;
            }
            
        }

        public void Update(GameTime gametime)
        {
            #region Random moves
            if (_particleRectangle.Y<=768)
            { _particleRectangle.Y += 3;}
            else
            {
                _particleRectangle = new Rectangle(_random.Next(0, 1366), 0 - _particleFramesTexture2Ds[0].Height, _particleFramesTexture2Ds[0].Width, _particleFramesTexture2Ds[0].Height);
            }
            if (_right >= 0)
            {
                _particleRectangle.X -= 1;
                _right--;
            }
            if (_left >= 0)
            {
                _particleRectangle.X += 1;
                _left--;
            }
            if (_right<=0 && _left<=0)
            {
                if (_random.Next(1, 3) == 1)
                {
                    _left = 10;
                    _right = 0;
                }
                else
                {
                    _left = 0;
                    _right = 10;
                }
            }
            #endregion
            #region Change of frames
            _timer += gametime.ElapsedGameTime;
            if (_timer.Milliseconds > 80)
            {
                _timer = TimeSpan.Zero;
                _counter++;
            }
            if (_counter > 5)
            {
                _counter = 0;
            }
            #endregion

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_particleFramesTexture2Ds[_counter],_particleRectangle,Color.White);
        }

    }
}
