using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DrawGame
{
    class Images
    {
        private readonly SpriteFont _spritefont;
        private readonly Texture2D _imagetex;       
        private readonly Texture2D _linetex;
        private readonly Vector2 _linevec;
        private readonly float _rotation;       
        private readonly string _caption = "";
       

        public Images(Texture2D line, Texture2D image, float rotat,SpriteFont font,string caption)
        {
            
            _caption = caption;
            _spritefont = font;
            _rotation = rotat;
            _linetex = line;
            _imagetex = image;
            _linevec = new Vector2(_linetex.Height, _linetex.Height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(_imagetex, _linevec, null, Color.White, _rotation, new Vector2(_imagetex.Width / 2f, _linetex.Height - 32), 1f, SpriteEffects.None, 0f);
            spriteBatch.DrawString(_spritefont, _caption, _linevec, Color.Black, _rotation, new Vector2(_spritefont.MeasureString(_caption).X / 2f, _linetex.Height - 15), 1f, SpriteEffects.None, 0f);
            
        }

       

    }
}
