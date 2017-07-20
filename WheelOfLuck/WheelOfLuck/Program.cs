using System;
using System.Windows.Forms;

namespace DrawGame
{

    internal static class Program
    {

        public static Preference GamePreference { get; set; }
        public static bool Exit { get; set; }

        private static void Main(string[] args)
        {

            GamePreference = new Preference();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var gameChooser = new GameChooser())
            {
                Application.Run(gameChooser);
            }

            if (!Exit)
            {
                
                using (var game = new Game1())
                {
                    game.Run();
                }
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }

}

