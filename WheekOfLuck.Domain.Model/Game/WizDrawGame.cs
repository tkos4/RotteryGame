using System.Collections.Generic;

namespace DrawGame.Domain.Model.Game
{
    public class WizDrawGame : BusinessObject
    {

        public WizDrawGame()
        {
            _gameItems = new List<WizDrawGameItem>();
            this.MarkNew();
        }


        public int GameId { get; set; }

        public string Name { get; set; }
      
        public int GameTypeId { get; set; }

        public bool IsActive { get; set; }

        public byte[] BackgroundImage { get; set; }
        public byte[] WinImage { get; set; }
        public byte[] LostImage { get; set; }
        public byte[] WinSound { get; set; }
        public byte[] LostSound { get; set; }
        

        private readonly List<WizDrawGameItem> _gameItems;
        public List<WizDrawGameItem> GameItems
        {
            get { return _gameItems; }
        }
	


    }
}