using System;
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



namespace TheSurvivor.Forms
{
    public partial class DeathScreen : Form
    {
        MediaPlayer mediaPlayer = new MediaPlayer();

        public DeathScreen()
        {
            InitializeComponent();
        }

        private void DeathScreen_Load(object sender, EventArgs e)
        {
            finalScoreLabel.Text += GameInformation.currentScore;

            mediaPlayer.Open(new Uri("E:\\Programming\\TheSurvivor\\Assets\\Sounds\\Death.wav"));
            mediaPlayer.Volume = 0.5;
            mediaPlayer.Play();

        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            mediaPlayer.Stop();

            Close();
            Game game = new Game();

            // Reset the players score
            GameInformation.currentScore = 0;

            game.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();

            Close();

            mainMenu.Show();
        }
    }
}
