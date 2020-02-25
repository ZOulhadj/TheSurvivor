using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor.Forms
{
    public partial class MainMenu : Form
    {
        Options optionsForm = new Options();

        public MainMenu()
        {
            InitializeComponent();

            // Disables form movement
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game();
            gameForm.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

            if (optionsForm is null)
            {
                optionsForm = new Options();
                optionsForm.Show();
            }
            else
            {
                optionsForm.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
