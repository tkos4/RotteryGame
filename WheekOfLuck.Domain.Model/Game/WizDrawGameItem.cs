using System;
using System.Drawing;

namespace DrawGame.Domain.Model.Game
{
    public class WizDrawGameItem : BusinessObject
    {
       
        private int _gameId;
        private int _gameItemId;
        private string _productCode="";
        private string _productName="";
        private string _backColor="255,255,255,255";
        private bool _isActive;
        private bool _isLoosing;
        private string _caption="";
        private byte[] _image ;
        private int _gameDrawBeforeWinsCount=0;
        private string _winningTitle = "";
       
        

        public int GamelId
        {
            get { return _gameId; }
            set
            {
                if (_gameId != value)
                {
                    _gameId = value;
                    this.MarkNew();
                    
                }

            }
        }

        public int GameItemId
        {
            get { return _gameItemId; }
            set
            {
                if (_gameItemId != value)
                {
                    _gameItemId = value;
                   
                    this.MarkModified();
                }
                
            }
        }

        public string ProductCode
        {
            get { return _productCode; }
            set
            {
                if (_productCode != value)
                {
                    _productCode = value;
                    this.MarkModified();
                }
                
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (_productName != value)
                {
                    _productName = value;
                    
                    this.MarkModified();
                }
            }
        }

        public Color BackColor{
            get { return GetColorFromString(_backColor); }
            set
            {
                if (_backColor != SetStringFromColor(value))
                {
                    _backColor = SetStringFromColor(value);
                   
                    this.MarkModified();
                }
            }
        }
        public string BackColorString
        {
            get { return _backColor; }
            set
            {
                if (_backColor != value)
                {
                    _backColor = value;

                    this.MarkModified();
                }
            }
        }

        public Boolean IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    
                    this.MarkModified();
                }
            }
        }

        public Boolean IsLoosing
        {
            get { return _isLoosing; }
            set
            {
                if (_isLoosing != value)
                {
                    _isLoosing = value;
                    
                    this.MarkModified();
                }
            }
        }

        public string Caption
        {
            get { return _caption; }
            set
            {
                if (_caption != value)
                {
                    _caption = value;
                    
                    this.MarkModified();
                }
            }
        }

        public byte[] Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    
                    this.MarkModified();
                }
            }
        }

        public int GameDrawBeforeWinsCount
        {
            get { return _gameDrawBeforeWinsCount; }
            set
            {
                if (_gameDrawBeforeWinsCount != value)
                {
                    _gameDrawBeforeWinsCount = value;
                   
                    this.MarkModified();
                }
            }
        }

        public string WinningTitle
        {
            get { return _winningTitle; }
            set
            {
                if (_winningTitle != value)
                {
                    _winningTitle = value;

                    this.MarkModified();
                }
            }
        }

        private Color GetColorFromString(string colorString)
        {
            string[] tokens = colorString.Split(',');

            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            
            Color color = Color.FromArgb(convertedItems[3],convertedItems[0],convertedItems[1], convertedItems[2]);

            return color;
        }

        private string SetStringFromColor(Color color)
        {
            return color.R + "," + color.G + "," + color.B + "," + color.A;
        }
    }
}