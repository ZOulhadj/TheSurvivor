using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

using TheSurvivor.Source.Utilities;
using TheSurvivor.Source.Music;



namespace TheSurvivor.Forms
{
    public partial class DeathScreen : Form
    {
        Sound deathSound;

        public DeathScreen()
        {
            InitializeComponent();

            // Play death screen soundtrack

            deathSound = new Sound(FileSystem.GetAsset("Sounds/Death.wav"));
        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {
            finalScoreLabel.Text += GameInformation.currentScore;


            deathSound.Play();
        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            Close();
            Game game = new Game();

            // Reset the players score
            GameInformation.currentScore = 0;

            game.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
