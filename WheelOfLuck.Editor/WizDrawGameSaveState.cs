using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;
using DrawGame.Domain.Model.Core;
using DrawGame.Editor.Properties;

namespace DrawGame.Editor
{
    class WizDrawGameSaveState
    {
        private List<int> _gameItemindexList = new List<int>();
        private WizDrawGame _wizDrawGame;
        private GameRepository _gameRepository;


        public WizDrawGameSaveState(WizDrawGame wizDrawGame)
        {
            _wizDrawGame = wizDrawGame;
            _gameRepository=new GameRepository(Settings.Default.ConnectionString);
            CreateIndex();
            
        }



        public void CreateIndex()
        {
            foreach (var gameItem in _wizDrawGame.GameItems)
            {
                _gameItemindexList.Add(gameItem.GameItemId);
            }
        }

        public void Save()
        {
            ChecksForGameItems();

            if (_wizDrawGame.ObjectState != ObjectState.New)
            {
                MarkGameItemsForSave();
            }

            var incomingWheel = _gameRepository.SaveWizDrawGame(_wizDrawGame);
            _wizDrawGame = incomingWheel;

            #region Reset the indexs
            _gameItemindexList.Clear();
            CreateIndex();
            if (_wizDrawGame.ObjectState == ObjectState.New)
            {
                _wizDrawGame.ObjectState = ObjectState.Unchanged;
            }

            #endregion


        }
        public void MarkGameItemsForSave()
        {
            #region Mark GameItems New or Modified

            foreach (var gameItem in _wizDrawGame.GameItems)
            {
                if (_gameItemindexList.Exists(x => x != gameItem.GameItemId))
                {
                    gameItem.MarkNew();
                    _wizDrawGame.MarkModified();

                }

                #region Checks
                if (gameItem.Caption == null)
                {
                    gameItem.Caption = " ";
                }
                if (gameItem.ProductName == null)
                {
                    gameItem.ProductName = " ";
                }
                if (gameItem.ProductCode == null)
                {
                    gameItem.ProductCode = " ";
                }
                if (gameItem.BackColor == null)
                {
                   // gameItem.BackColor = "255,255,255,255";
                }
                #endregion
            }

            #endregion

            var gameItemForDelete = _gameItemindexList.Where(i => _wizDrawGame.GameItems.Exists(x => x.GameItemId != i)).ToList();
            
            #region Delete the GameItems
            foreach (var i in gameItemForDelete)
            {
                _gameRepository.DeleteGameItem(i);

            }
            #endregion
            

            _wizDrawGame.MarkModified();


        }

        public void ChecksForGameItems()
        {
            foreach (var GameItem in _wizDrawGame.GameItems.Where(GameItem => (GameItem.Image) == null))
            {
                var empty = new Bitmap(1, 1);
                using (var memorystream = new MemoryStream())
                {
                    empty.Save(memorystream, ImageFormat.Png);
                    memorystream.Close();
                    GameItem.Image = memorystream.ToArray();

                }
            }
        }

    }
}
