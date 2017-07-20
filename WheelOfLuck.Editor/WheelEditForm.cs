using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DrawGame.Client;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model;
using DrawGame.Domain.Model.Core;
using DrawGame.Domain.Model.Game;
using DrawGame.Editor.Properties;

namespace DrawGame.Editor
{
  
    public partial class WheelEditForm : Form
    {
        #region Declerations
        private int _currentWheel;
        private bool _savePressed ;
        private bool _edit ;
        private int _dataGridViewCellId = 0;
        
        private int _colorIndex;
        int _defaultWheel;
        private List<int> _wheelForSave=new List<int>(); 

        readonly List<int> _wheelDelete=new List<int>();
        List<int> _GameItemindexList=new List<int>();
        readonly List<List<int>> _wheelIndex=new List<List<int>>(); 
        private readonly GameRepository _gameRepository = new GameRepository(Settings.Default.ConnectionString);

        readonly BindingList<WizDrawGame> _wheels = new BindingList<WizDrawGame>();
        DrawService calculateDraw;
        #endregion

        //On start methods    
        public WheelEditForm()
        {
            InitializeComponent();
            calculateDraw = new DrawService();
            dataGridView2.DefaultCellStyle.NullValue = null;
            _edit = false;


           // _wheels = _gameRepository.GetAllDrawGames();
            wheelBindingSource.DataSource = _wheels;
            
            
            CreateIndex();
            combo.DataSource = Enum.GetValues(typeof (GameType));


            _currentWheel =  0;
            
                
            

        }                      
        public void CreateIndex()
        {
            bool find = false;                      

            for (var i = 0; i < _wheels.Count; i++)
            {

                foreach (var GameItem in _wheels[i].GameItems)
                {
                    _GameItemindexList.Add(GameItem.GameItemId);
                }

                _wheelIndex.Add(_GameItemindexList);

                _GameItemindexList = new List<int>();
                
                if (_wheels[i].GameId == _defaultWheel)
                {
                   
                    _defaultWheel = i;
                    find = true;
                }
                
            }
            if (!find)
            {
                _defaultWheel = 0;
            }

        }
        private void WheelEditForm_Shown(object sender, EventArgs e)
        {
            _currentWheel = _defaultWheel;
            if (_wheels.Count > 0)
            {

                dataGridView2.CurrentCell = dataGridView2.Rows[_defaultWheel].Cells[0];

                ColorRows();
            }
        }        
        //

        //On Exit methods
        private void WheelEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_savePressed && _edit)
            {
                var messageBox = MessageBox.Show(Resources.WheelEditForm_WheelEditForm_FormClosing_Θέλετε_να_αποθηκεύσετε_τις_αλλαγές_που_κάνετε_, Resources.WheelEditForm_WheelEditForm_FormClosing_Εξοδος, MessageBoxButtons.YesNoCancel);
                if (messageBox == DialogResult.Yes)
                {
                    SaveButton_Click(null, null);
                }
                else if (messageBox == DialogResult.No)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        //
       
        //Game Buttons
        private void BackgroundForGameButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files (JPEG,PNG)|*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    _wheels[_currentWheel].BackgroundImage = itemAsBytes;
                   
                }
                catch 
                {
                }
            }
            

        }
        private void WinImageForGameButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPEG,PNG)|*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    _wheels[_currentWheel].WinImage = itemAsBytes;
                   
                }
                catch
                {
                }
            }
            
        }
        private void LostImageForGameButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files (JPEG,PNG)|*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    _wheels[_currentWheel].LostImage = itemAsBytes;
                    
                }
                catch
                {
                }
            }
        }
        private void WinSoundForGameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                " * Must be a PCM wave file \n * Can only be mono or stereo\n * Must be 8 or 16 bit\n * Sample rate must be between 8,000 Hz and 48,000 Hz","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Information);
            openFileDialog1.Filter = "Sounds Files (*.wav)|*.wav;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    _wheels[_currentWheel].WinSound = itemAsBytes;
                    
                }
                catch
                {
                }
            }
        }
        private void LostSoundForGameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  " * Must be a PCM wave file \n * Can only be mono or stereo\n * Must be 8 or 16 bit\n * Sample rate must be between 8,000 Hz and 48,000 Hz", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            openFileDialog1.Filter = "Sounds Files (*.wav)|*.wav;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    var fs1 = new FileStream(file, FileMode.Open);
                    var itemAsBytes = new byte[fs1.Length];
                    fs1.Read(itemAsBytes, 0, itemAsBytes.Length);
                    fs1.Close();

                    _wheels[_currentWheel].LostSound = itemAsBytes;
                    

                }
                catch
                {
                }
            }
            
        }
        //

        //Editor Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            _wheelForSave.Add(_currentWheel);
            foreach (var id in _wheelForSave)
            {
                _currentWheel= id;

                UseWaitCursor = true;
                bool error = false;
                bool notLoseGamePart = false;
                if (_currentWheel < _wheels.Count)
                {
                    #region Check for GameItems
                    if( !_wheels[_currentWheel].GameItems.Exists(x=>x.IsLoosing))
                    {
                        notLoseGamePart = true;
                    }
                    foreach (var GameItem in _wheels[_currentWheel].GameItems.Where(GameItem =>(GameItem.Image)==null))
                    {
                        if (!GameItem.IsLoosing)
                        {
                            error = true;
                        }
                        else
                        {
                            var empty=new Bitmap(1,1);                           
                            using (var memorystream = new MemoryStream())
                            {
                                empty.Save(memorystream,ImageFormat.Png);
                                memorystream.Close();
                                GameItem.Image = memorystream.ToArray();
                                
                            }
                             
                        }
                    }

                    if (!error && !notLoseGamePart)
                    {
                        Save();
                        _savePressed = true;
                        

                    }
                    if (error)
                    {
                        MessageBox.Show(Resources.WheelEditForm_button2_Click_Βαλτε_σε_ολα_τα_κομματια_μια_εικονα,
                            Resources.WheelEditForm_button2_Click_ΠΡΟΣΟΧΗ, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (notLoseGamePart)
                    {
                        MessageBox.Show(Resources.WheelEditForm_button2_Click_Παρακαλώ_βάλτε_το_πολύ_ένα_κομμάτι_που_χάνει,
                            Resources.WheelEditForm_button2_Click_ΠΡΟΣΟΧΗ, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    #endregion

                   
                }
            }
            UseWaitCursor = false;
            _wheelForSave.Clear();
            _wheelForSave=new List<int>();
            ColorRows();
            var message= MessageBox.Show(Resources.WheelEditForm_SaveButton_Click_,Resources.WheelEditForm_SaveButton_Click_ΠΡΟΕΙΔΟΠΟΙΗΣΗ, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            {
                if (calculateDraw.RestartServer())
                {
                    MessageBox.Show("Server has restarted successfully", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Server has not restarted successfully. Please try again later.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //


        //GamePart Buttons
        private void ColorForGamePartButton_Click(object sender, EventArgs e)
        {
            var coloResult = colorDialog1.ShowDialog();
            if (coloResult == DialogResult.OK)
            {
               
                try
                {
                    _wheels[_currentWheel].GameItems[_colorIndex].BackColor = colorDialog1.Color;

                    dataGridView1.Rows[_colorIndex].Cells[6].Style.BackColor = colorDialog1.Color;
                    dataGridView1.Rows[_colorIndex].Cells[6].Style.ForeColor = colorDialog1.Color;
                    _edit = true;
                }
                catch
                { }
            }
        }
        private void ImageForGamePartButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files (JPEG,PNG)|*.jpg;*.jpeg;*.png;";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    byte[] imageAsBytes = new byte[fs.Length];
                    fs.Read(imageAsBytes, 0, imageAsBytes.Length);
                    fs.Close();
                    _wheels[_currentWheel].GameItems[_colorIndex].Image = imageAsBytes;

                }
                catch
                {
                }

            }

        }
        //


       
        //Save Methods
        public void Save()
        {

            if (_wheels[_currentWheel].ObjectState != ObjectState.New)
            {
                MarkGameItemsForSave();
            }

            var incomingWheel = _gameRepository.SaveWizDrawGame(_wheels[_currentWheel]);
            _wheels[_currentWheel] = incomingWheel;

            #region Reset the indexs
            _wheelIndex.Clear();
            CreateIndex();
            if (_wheels[_currentWheel].ObjectState == ObjectState.New)
            {
                _wheels[_currentWheel].ObjectState = ObjectState.Unchanged;
            }
            
            #endregion




            MessageBox.Show(Resources.WheelEditForm_OnExit_επιτυχής_αποθηκευση, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void MarkGameItemsForSave()
        {
            #region Mark GameItems New or Modified

            bool find1 = false;
            foreach (WizDrawGameItem GameItem in _wheels[_currentWheel].GameItems)
            {
                if (_wheelIndex[_currentWheel].Exists(x => x == GameItem.GameItemId))
                {
                    if (GameItem.ObjectState == ObjectState.Modified)
                    {
                        _wheels[_currentWheel].MarkModified();

                    }
                    find1 = true;
                }

                if (_wheelIndex[_currentWheel].Count < _wheels[_currentWheel].GameItems.Count && !find1)
                {

                    GameItem.MarkNew();
                    GameItem.GamelId = _currentWheel;
                    _wheels[_currentWheel].MarkModified();

                }
                find1 = false;

                #region Checks

                if (GameItem.Caption == null)
                {
                    GameItem.Caption = " ";
                }
                if (GameItem.ProductName == null)
                {
                    GameItem.ProductName = " ";
                }
                if (GameItem.ProductCode == null)
                {
                    GameItem.ProductCode = " ";
                }
                



                #endregion
            }

            #endregion

            var GameItemForDelete = new List<int>();
            bool find2 = false;
            #region Mark GameItems For Delete
            foreach (var i in _wheelIndex[_currentWheel])
            {
                if (_wheels[_currentWheel].GameItems.Exists(x => x.GameItemId == i))
                {
                    find2 = true;
                }
                if (!find2)
                {
                    GameItemForDelete.Add(i);

                }
                find2 = false;
            }
            #endregion
            #region Delete the GameItems
            foreach (var i in GameItemForDelete)
            {
                _gameRepository.DeleteGameItem(i);

            }
            #endregion
            #region Delete the Wheel
            foreach (var id in _wheelDelete)
            {
                _gameRepository.DeleteWizDrawGame(id);
            }
            #endregion

            _wheels[_currentWheel].MarkModified();


        }
        //
       

        //Functional and Visual Methods
        public void ColorRows()
        {
            try
            {
                for (int i = 0; i < _wheels[_currentWheel].GameItems.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[6].Style.BackColor =_wheels[_currentWheel].GameItems[i].BackColor;
                    dataGridView1.Rows[i].Cells[6].Style.ForeColor = dataGridView1.Rows[i].Cells[6].Style.BackColor;
                }
            }
            catch { }


        }
        public Color GetColorFromString(string colorString)
        {
            if (colorString != null)
            {
                var tokens = colorString.Split(',');

                var convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

                var color = Color.FromArgb(convertedItems[0], convertedItems[1], convertedItems[2]);

                return color;
            }

            return Color.White;

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Focus())
            {
                _colorIndex = dataGridView1.CurrentCell != null ? dataGridView1.CurrentCell.RowIndex : 0;
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _edit = true;

        }
        //


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show(Resources.WheelEditForm_dataGridView1_CellContentClick_Θελετε_να_διαγραψετε_αυτο_το_πεδιο_οριστικα_, Resources.WheelEditForm_dataGridView1_CellContentClick_Διαγραφη_Πεδιου, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                        _edit = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
                catch
                { }
            }
            if (e.ColumnIndex == 7)
            {
                _edit = true;
            }
            if (e.ColumnIndex == 8)
            {
                _edit = true;
            }

        }       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show(Resources.WheelEditForm_dataGridView1_CellContentClick_Θελετε_να_διαγραψετε_αυτο_το_πεδιο_οριστικα_, Resources.WheelEditForm_dataGridView1_CellContentClick_Διαγραφη_Πεδιου, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _wheelDelete.Add(_wheels[_currentWheel].GameId);
                        dataGridView2.Rows.Remove(dataGridView2.Rows[e.RowIndex]);

                        _edit = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }
                catch
                { }
            }
            _dataGridViewCellId = e.ColumnIndex;

        }       
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4) 
            {
                int i;
                

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    
                    e.Cancel = true;
                    MessageBox.Show(Resources.WheelEditForm_dataGridView1_CellValidating_Αυτό_το_πεδίο_δέχεται_μόνο_νούμερα, Resources.WheelEditForm_button2_Click_ΠΡΟΣΟΧΗ, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (Convert.ToInt32(e.FormattedValue) < 0)
                {
                    e.Cancel = true;
                    
                    MessageBox.Show(
                        Resources
                            .WheelEditForm_dataGridView1_CellValidating_Παρακαλώ_βάλτε_ένα_νούμερο_μεγαλύτερο_του_μηδέν,
                        Resources.WheelEditForm_button2_Click_ΠΡΟΣΟΧΗ, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }        
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Focused)
            {
                if (!_savePressed && _edit)
                {
                    if (!_wheelForSave.Exists(x => x == _currentWheel))
                    {
                        _wheelForSave.Add(_currentWheel);
                    }
                    _edit = false;
                }
                _currentWheel = e.RowIndex;
                ColorRows();
               
               
            }

        }       
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView2.Focused)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (_dataGridViewCellId == 3)
                    {
                        _wheels[_currentWheel].BackgroundImage = null;
                        dataGridView2.Refresh();
                    }
                    if (_dataGridViewCellId == 4)
                    {
                        _wheels[_currentWheel].WinImage = null;
                        dataGridView2.Refresh();
                    }
                    if (_dataGridViewCellId == 5)
                    {
                        _wheels[_currentWheel].LostImage = null;
                        dataGridView2.Refresh();
                    }
                    if (_dataGridViewCellId == 6)
                    {
                        _wheels[_currentWheel].WinSound = null;
                        dataGridView2.Refresh();
                    }
                    if (_dataGridViewCellId == 7)
                    {
                        _wheels[_currentWheel].LostSound = null;
                        dataGridView2.Refresh();
                    }
                }
            }
        }

        

    }
}
