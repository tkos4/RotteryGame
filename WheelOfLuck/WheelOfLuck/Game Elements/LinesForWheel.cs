using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DrawGame
{
    class Lines
    {

        public Texture2D Linetex;
        private readonly Color _partitionColor=Color.White;
        private float _ratius;

        public Lines(Texture2D image, float ratius,Color color)
        {
            Linetex = image;
            _ratius = ratius;
            _partitionColor = color;
           
        }

        public void Update()
        {
            _ratius += 0.01f;
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        spriteBatch.Draw(Linetex, new Vector2(Linetex.Height, Linetex.Height), null, _partitionColor, _ratius,new Vector2(0, Linetex.Height), 1f, SpriteEffects.None, 0f);

        }

    }
}