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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }


        private void toggleMusicButton_Click(object sender, EventArgs e)
        {
            if (toggleMusicLabel.Text == "On")
            {
                toggleMusicLabel.Text = "Off";
                toggleMusicLabel.ForeColor = Color.Red;
            }
            else if (toggleMusicLabel.Text == "Off")
            {
                toggleMusicLabel.Text = "On";
                toggleMusicLabel.ForeColor = Color.Green;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();
            
            mainMenuForm.Show();
            Hide();
        }
    }
}
