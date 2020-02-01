using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using TheSurvivor.Source;

namespace TheSurvivor
{
    public partial class Game : Form
    {
        bool isPaused = false;
        bool isJumping = false;

        Player player = new Player();

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            SoundPlayer soundTrack = new SoundPlayer(@"C:/Users/zakar/Downloads/test.wav");
            //soundTrack.Play();

            playerObject.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!playerObject.Bounds.IntersectsWith(ground.Bounds) && isJumping == false)
            {
                playerObject.Top += 1 * player.GetPlayerSpeed();
            }

            // Keep the player within the form window
            if (playerObject.Location.X <= 0)
                playerObject.Location = new Point(0, playerObject.Location.Y);
            if (playerObject.Location.X >= Width - playerObject.Width)
                playerObject.Location = new Point(Width - playerObject.Width, playerObject.Location.Y);
            
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "platform" && isJumping == false)
                {
                    if (playerObject.Bounds.IntersectsWith(control.Bounds))
                    {
                        playerObject.Top -= 1 * player.GetPlayerSpeed();
                    }

                     if (playerObject.Bounds.Bottom == control.Bounds.Top)
                        playerObject.Top -= 1 * player.GetPlayerSpeed();
                }
            }

            if (playerObject.Bounds.IntersectsWith(platform.Bounds))
            {
                playerObject.Top -= 1 * player.GetPlayerSpeed();
            }
        }

        private void upMovement_Tick(object sender, EventArgs e)
        {
            playerObject.Top -= 1 * player.GetPlayerSpeed();
            isJumping = true;
        }

        private void leftMovement_Tick(object sender, EventArgs e)
        {
            playerObject.Left -= 1 * player.GetPlayerSpeed();
        }

        private void rightMovement_Tick(object sender, EventArgs e)
        {
            playerObject.Left += 1 * player.GetPlayerSpeed();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                upMovement.Start();
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                leftMovement.Start();
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                rightMovement.Start();


            // Handle pause menu from within the game
            if (e.KeyCode == Keys.Escape)
            {
                if (isPaused)
                {
                    pausePanel.Visible = false;
                    isPaused = false;
                }
                else
                {
                    pausePanel.Visible = true;
                    isPaused = true;
                }

            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                upMovement.Stop();
                isJumping = false;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                leftMovement.Stop();
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                rightMovement.Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // TODO: Fix input not working after clicking continue
            pausePanel.Visible = false;
            isPaused = false;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Forms.Options options = new Forms.Options();

            options.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
