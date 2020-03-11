using System;
using System.Windows.Forms;

using TheSurvivor.Source.Utilities;

namespace TheSurvivor.Forms
{
    public partial class MainMenu : Form
    {
        Options optionsForm = new Options();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game();
            gameForm.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
                Logging.Log(LogType.LOG, "Displaying options form");
                optionsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
