using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DrawGame
{
    public class CurtainBox
    {
        private readonly Texture2D _curtainCoverTex;
        private readonly Texture2D _curtainTexture2D;
        private Rectangle _curtainRectangle;

        private bool _mouseCover;
        private bool _mousepressed;


        public CurtainBox(Texture2D cureTexInco, Rectangle cureRecInco, Texture2D coverTexture2D)
        {
            _curtainCoverTex = coverTexture2D;
            _curtainTexture2D = cureTexInco;
            _curtainRectangle = cureRecInco;           
           
        }

        
        public void Update(MouseState mouse)
        {
            #region Mouse Check
            if (_curtainRectangle.Contains(mouse.X, mouse.Y))
            {
                _mouseCover = true;
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    _mousepressed = true;
                    
                }
                if (_mousepressed && mouse.LeftButton == ButtonState.Released)
                {
                    Click = true;
                    _mousepressed = false;
                }

            }
            else
            {
                _mouseCover = false;
                _mousepressed = false;
            }
            #endregion

            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(_curtainTexture2D, _curtainRectangle,  Color.White);
            if (_mouseCover)
            {
                spriteBatch.Draw(_curtainCoverTex, _curtainRectangle, Color.White);
            }
        }


        public bool Click { get; set; }
    }
}
