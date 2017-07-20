using System;
using DrawGame.Domain.Model.Core;
using DrawGame.Domain.Model.Game;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DrawGame.ViewModels
{
    public class GameItemViewModel: NotificationObject
    {

        #region Members

        private WizDrawGameItem _wizDrawGameItem;

        #endregion

        #region Contructors
        public GameItemViewModel(WizDrawGameItem GameItem )
        {
            _wizDrawGameItem = GameItem;
      
        }
        #endregion

        #region Properties

        public int GameItemId
        {
            get { return _wizDrawGameItem.GameItemId; }
            set
            {
                if (_wizDrawGameItem.GameItemId != value)
                {
                    _wizDrawGameItem.GameItemId = value;
                    this.OnPropertyChanged("GameItemId");
                }

            }
        }

        public string ProductCode
        {
            get { return _wizDrawGameItem.ProductCode; }
            set
            {
                if (_wizDrawGameItem.ProductCode != value)
                {
                    _wizDrawGameItem.ProductCode = value;
                    this.OnPropertyChanged("ProductCode");
                }
            }
        }

        public string ProductName
        {
            get { return _wizDrawGameItem.ProductName; }
            set
            {
                if (_wizDrawGameItem.ProductName != value)
                {
                    _wizDrawGameItem.ProductName = value;
                    this.OnPropertyChanged("ProductName");
                }
            }
        }

        private void GetColorFromString()
        {
            string[] tokens = _wizDrawGameItem.BackColorString.Split(',');

            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

            _wheelBackColor1 = Color.FromNonPremultiplied(convertedItems[0], convertedItems[1], convertedItems[2], convertedItems[3]);
        }

        private Color _wheelBackColor1;
        public Color GameItemBackColor1
        {
            get
            {
                if (_wheelBackColor1.Equals(Color.Transparent ))
                {
                    GetColorFromString();
                }

                return _wheelBackColor1;
            }
            set
            {

                if (!_wheelBackColor1.Equals( value))
                {
                   var colorString = value.ToWizcomString();

                   _wizDrawGameItem.BackColorString = value.ToWizcomString(); 
                    
                    _wheelBackColor1 = value;

                    this.OnPropertyChanged("GameItemBackColor1");
                }
            }
        }

        public Boolean IsActive
        {
            get { return _wizDrawGameItem.IsActive; }
            set
            {
                if (_wizDrawGameItem.IsActive != value)
                {
                    _wizDrawGameItem.IsActive = value;
                    this.OnPropertyChanged("IsActive");
                }
            }
        }

        public Boolean IsLoosingPie
        {
            get { return _wizDrawGameItem.IsLoosing; }
            set
            {
                if (_wizDrawGameItem.IsLoosing != value)
                {
                    _wizDrawGameItem.IsLoosing = value;
                    this.OnPropertyChanged("IsLosing");
                }
            }
        }

        public string Caption
        {
            get { return _wizDrawGameItem.Caption; }
            set
            {
                if (_wizDrawGameItem.Caption != value)
                {
                    _wizDrawGameItem.Caption = value;
                    this.OnPropertyChanged("Caption");
                }
            }
        }

        public byte[] ImagePath
        {
            get { return _wizDrawGameItem.Image; }
            set
            {
                if (_wizDrawGameItem.Image != value)
                {
                    _wizDrawGameItem.Image = value;
                    this.OnPropertyChanged("ImagePath");
                }
            }
        }

        private Texture2D _image;
        public Texture2D Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    this.OnPropertyChanged("Image");
                }
            }
        }

        
        public Texture2D ImageOriginal { get; set; }

        public int WheelDrawBeforeWinsCount
        {
            get { return _wizDrawGameItem.GameDrawBeforeWinsCount; }
            set
            {
                if (_wizDrawGameItem.GameDrawBeforeWinsCount != value)
                {
                    _wizDrawGameItem.GameDrawBeforeWinsCount = value;
                    this.OnPropertyChanged("AmountOfPeople");
                }
            }
        }

        public string WinningTitle
        {
            get { return _wizDrawGameItem.WinningTitle; }
            set
            {
                if (_wizDrawGameItem.WinningTitle != value)
                {
                    _wizDrawGameItem.WinningTitle = value;
                    this.OnPropertyChanged("WinningTitle");
                }
            }
        }

        #endregion

    }
}
