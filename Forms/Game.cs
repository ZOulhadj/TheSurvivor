using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using TheSurvivor.Source;

namespace TheSurvivor
{

    public partial class Game : Form
    {
        Player player;

        public Game()
        {
            InitializeComponent();
            
            // Initialise sub components
            player = new Player(playerObject);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Player movement
            switch (player.input.GetCurrentKey())
            {
                case Key.KEY_A:
                    foreach (Control control in Controls)
                    {
                        if ((string)control.Tag == "platform")
                        {
                            control.Left += player.GetSpeed();
                        }
                    }
                    break;
                case Key.KEY_D:
                    foreach (Control control in Controls)
                    {
                        if ((string)control.Tag == "platform")
                        {
                            control.Left -= player.GetSpeed();
                        }
                    }
                    break;
                case Key.KEY_SPACE:
                    // Move all platforms down during jump
                    foreach (Control control in Controls)
                    {
                        if ((string)control.Tag == "platform")
                        {
                            control.Top += player.GetSpeed();
                        }
                    }
                    player.SetJumping(true);
                    break;
                default:
                    player.SetJumping(false);
                    break;
            }

            // Check if the player is colliding with an object while not jumping
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "platform" && !player.IsJumping())
                {
                    if (control.Left < player.GetPlayer().Left + player.GetPlayer().Width &&
                        control.Left + control.Width > player.GetPlayer().Left &&
                        control.Top < player.GetPlayer().Top + player.GetPlayer().Height &&
                        control.Top + control.Height > player.GetPlayer().Top)
                    {
                        player.m_Collision = true;
                    }
                }
            }

            // Second pass to move or keep the platforms stationary
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "platform" && !player.IsJumping())
                {
                    if (player.m_Collision)
                    {
                        /* Find out which way the world needs to be transformed
                         * based on which side the player is colliding with
                         * the object.
                         */
                    }
                    else
                    {
                        control.Top -= player.GetSpeed();
                    }
                }

            }

            // Reset collision flag
            player.m_Collision = false;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            player.input.SetKeyDown(e.KeyCode);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            player.input.SetKeyReleased();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // TODO: Fix input not working after clicking continue
            pausePanel.Visible = false;
            //isPaused = false;
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
