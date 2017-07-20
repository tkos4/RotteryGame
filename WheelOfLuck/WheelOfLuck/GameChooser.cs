using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;

namespace DrawGame
{
    public partial class GameChooser : Form
    {
        private string _branchCode;

        private bool _buttenOkPressed;
        private GameRepository _wheelRepository;
        private BindingList<WizDrawGame> _wheels;
        public GameChooser()
        {
            InitializeComponent();
            
            
        }

        private void GameChooser_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add(ParticlesStyle.Snow);
            listBox2.Items.Add(ParticlesStyle.Confetti);
            listBox2.Items.Add(ParticlesStyle.CoffeeBeans);

            LoadPreferences();
            var hostname = "";
            if (File.Exists("connectionString.cfg"))
            {
                hostname = File.ReadAllText("connectionString.cfg");
            }
            _wheelRepository =new GameRepository(hostname);
            _wheels=new BindingList<WizDrawGame>();

            var gameIds = _wheelRepository.GetBranchGamesByBranchCode(_branchCode);
            foreach (var gameId in gameIds)
            {
                _wheels.Add(_wheelRepository.GetWizDrawGameById2(gameId));
            }
            

            foreach (var wheel in _wheels)
            {
                listBox1.Items.Add(wheel.Name);
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item= listBox1.SelectedIndex;
            var gameId = _wheels[item].GameId;
            Program.GamePreference.GameId = gameId;
            Program.GamePreference.LighsOn = lights.Checked;
            Program.GamePreference.SoundOn = sounds.Checked;
            Program.GamePreference.ParticlesStyle = (ParticlesStyle)listBox2.SelectedIndex;
            _buttenOkPressed = true;
            SavePreferences();
            this.Close();
        }

        private void GameChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !_buttenOkPressed)
            {
                var messagebox = MessageBox.Show("Θελετε να κλεισετε το παιχνιδι;", "ΕΞΟΔΟΣ", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (messagebox == DialogResult.Yes)
                {
                    Program.Exit = true;                    
                }
                else
                {
                    e.Cancel = true;
                    Program.Exit = false;
                }
            }
           
            

        }

        void SavePreferences()
        {
            string save = listBox1.SelectedIndex + "," + listBox2.SelectedIndex + "," + lights.Checked + "," +
                          sounds.Checked+"," + _branchCode;
            File.WriteAllText("Settings/Preferences.txt",save);
        }

        private void LoadPreferences()
        {
            if (File.Exists("Settings/Preferences.txt"))
            {
                var file = File.ReadAllText("Settings/Preferences.txt");
                string[] load = file.Split(',');
                //listBox1.SelectedIndex = Convert.ToInt32(load[0]);
                listBox2.SelectedIndex = Convert.ToInt32(load[1]);
                lights.Checked = Convert.ToBoolean(load[2]);
                sounds.Checked = Convert.ToBoolean(load[3]);
                _branchCode = load[4];
            }
        }
    }
}
