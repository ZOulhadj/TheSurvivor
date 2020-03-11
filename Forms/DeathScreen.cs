using System;
using System.Windows.Forms;
using TheSurvivor.Source.Music;
using TheSurvivor.Source.Utilities;



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
