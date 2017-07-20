using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Core;
using DrawGame.Domain.Model.Game;

namespace DrawGame.Editor
{
    public partial class GameEditForm : DevExpress.XtraEditors.XtraForm
    {

       

        public delegate void RefreshHandler();

        public event RefreshHandler RefreshEvent;

        protected virtual void OnRefreshEvent()
        {
            RefreshHandler handler = RefreshEvent;
            if (handler != null) handler();
        }


        private WizDrawGameSaveState _wizDrawGameSaveState;


        public GameEditForm()
        {
            InitializeComponent();
            LoadValueLists();

            

        }

        public void LoadValueLists()
        {

            var gameTypeList = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "WheelGame"),
                new KeyValuePair<int, string>(1, "CurtainGame")
            };
            this.GameTypeLookUpEdit.Properties.DataSource = gameTypeList;
            GameTypeLookUpEdit.Properties.DisplayMember = "Value";
            GameTypeLookUpEdit.Properties.ValueMember = "Key";
        }

        public WizDrawGame Datasource
        {
            get { return (WizDrawGame) this.wizDrawGameBindingSource.DataSource; }
            set
            {
                this.wizDrawGameBindingSource.DataSource = value;
                _wizDrawGameSaveState = new WizDrawGameSaveState(Datasource);
                ActivateSoundButtons();
            }
        }

        #region MainButtons
        private void SaveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Validate(false);
            _wizDrawGameSaveState.Save();
            RefreshEvent.Invoke();
        }

        private void ExitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void DeleteSimpleButton_Click(object sender, System.EventArgs e)
        {           
            GameItemsGridView.DeleteRow(GameItemsGridView.FocusedRowHandle);

        }

        private void NewSimpleButton_Click(object sender, System.EventArgs e)
        {
            GameItemsGridView.AddNewRow();
        }

        #endregion

        #region Parse events

        private void ImagePictureEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var value = e.Value;

            if (value.GetType().ToString() == "System.Drawing.Bitmap")
            {
                ImageConverter converter = new ImageConverter();

                var bytes = (byte[])converter.ConvertTo(value, typeof(byte[]));

                e.Value = bytes;
            }
        }

        private void BackgroundImagePictureEdit_ParseEditValue(object sender,
            DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var value = e.Value;

            if (value.GetType().ToString() == "System.Drawing.Bitmap")
            {
                ImageConverter converter = new ImageConverter();

                var bytes = (byte[]) converter.ConvertTo(value, typeof (byte[]));

                e.Value = bytes;
            }

        }

        private void WinImagePictureEdit_ParseEditValue(object sender,
            DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var value = e.Value;

            if (value.GetType().ToString() == "System.Drawing.Bitmap")
            {
                ImageConverter converter = new ImageConverter();

                var bytes = (byte[]) converter.ConvertTo(value, typeof (byte[]));

                e.Value = bytes;
            }
        }

        private void LostImagePictureEdit_ParseEditValue(object sender,
            DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var value = e.Value;

            if (value.GetType().ToString() == "System.Drawing.Bitmap")
            {
                ImageConverter converter = new ImageConverter();

                var bytes = (byte[]) converter.ConvertTo(value, typeof (byte[]));

                e.Value = bytes;
            }
        }

        private void GameTypeLookUpEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            //if (e.Value == null) return;

            //var value = (GameType)e.Value;

            //e.Value = value;


        }

        #endregion

        #region Sounds converters
        private void WinSoundPictureEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show(
               " * Must be a PCM wave file \n * Can only be mono or stereo\n * Must be 8 or 16 bit\n * Sample rate must be between 8,000 Hz and 48,000 Hz",
               "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileDialog1.Filter = "Sounds Files (*.wav)|*.wav;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    Datasource.WinSound = itemAsBytes;
                    WinSoundPictureEdit.Text = openFileDialog1.FileName;
                    ActivateSoundButtons();
                }
                catch
                {
                }
            }

        }

        private void LostSoundPictureEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show(
                " * Must be a PCM wave file \n * Can only be mono or stereo\n * Must be 8 or 16 bit\n * Sample rate must be between 8,000 Hz and 48,000 Hz",
                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            openFileDialog1.Filter = "Sounds Files (*.wav)|*.wav;";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    Datasource.LostSound = itemAsBytes;
                    LostSoundPictureEdit.Text = openFileDialog1.FileName;
                    ActivateSoundButtons();
                }
                catch
                {
                }
            }

        }

        #endregion

        private void PlayWinSimpleButton_Click(object sender, EventArgs e)
        {
            if (Datasource.WinSound != null)
            {
                var soundPlayer = new SoundPlayer();
                soundPlayer.Stream = new MemoryStream(this.Datasource.WinSound);
                soundPlayer.PlaySync();
            }
        }

        private void PlayLostSimpleButton_Click(object sender, EventArgs e)
        {
            if (Datasource.LostSound != null)
            {
                var soundPlayer = new SoundPlayer();
                soundPlayer.Stream = new MemoryStream(this.Datasource.LostSound);
                soundPlayer.PlaySync();
            }
        }


        private void ActivateSoundButtons()
        {
            PlayWinSimpleButton.Enabled = Datasource.WinSound != null;
            PlayLostSimpleButton.Enabled = Datasource.LostSound != null;

        }

        

       
    }

   
}