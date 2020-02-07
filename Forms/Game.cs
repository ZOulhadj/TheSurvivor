using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using TheSurvivor.Source;

namespace TheSurvivor
{

    public partial class Game : Form
    {
        Random rand = new Random();
        Player player;
        Input input = new Input();
        
        public Game()
        {
            InitializeComponent();
            
            // Initialise sub components
            player = new Player(playerControl);

            // Platform generation
            int platformCount = 150;
            for (int i = 0; i < platformCount; ++i)
            {
                if (i < platformCount - 1)
                {
                    PictureBox platform = new PictureBox();
                    platform.ClientSize = new Size(rand.Next(50, 100), 20);
                    platform.Padding = new Padding(500);
                    platform.Location = new Point(rand.Next(100, ClientSize.Width - 100), rand.Next(ClientSize.Height - 100, 10000));
                    platform.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    platform.Tag = "platform";
                    platform.BringToFront();

                    Controls.Add(platform);
                }

                // TODO: Add a final platform
                //else
                //{
                //    PictureBox platform = new PictureBox();
                //    platform.ClientSize = new Size(ClientSize.Width, 20);
                //    platform.Padding = new Padding(500);
                //    platform.Location = new Point(0, ClientSize.Height);
                //    platform.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                //    platform.Tag = "platform";
                //    platform.BringToFront();

                //    Controls.Add(platform);
                //}
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Player movement
            if (input.IsKeyPressed(Keys.A) || input.IsKeyPressed(Keys.D))
            {
                xAxisMovementTimer.Start();
            } else if (input.IsKeyPressed(Keys.Space))
            {
                yAxisMovementTimer.Start();
            }

            foreach (Control control in Controls)
            {
                // If control location is outside the window then discard it from rendering

                // Check if the player is colliding with an object while not jumping
                if ((string)control.Tag == "platform" && !player.IsJumping())
                {
                    if (control.Left < player.GetPlayer().Left + player.GetPlayer().Width &&
                        control.Left + control.Width > player.GetPlayer().Left &&
                        control.Top < player.GetPlayer().Top + player.GetPlayer().Height &&
                        control.Top + control.Height > player.GetPlayer().Top)
                    {
                        player.m_Collision = true;
                        //control.BackColor = Color.Green;
                    }
                    else
                    {
                        //control.BackColor = Color.White;
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

            // Increase lava height over time
            //lavaControl.Top -= 1;
            //lavaControl.Height += 1;

        }

        private void xAxisMovementTimer_Tick(object sender, EventArgs e)
        {
            if (input.IsKeyPressed(Keys.A))
            {
                //foreach (Control control in Controls)
                //{
                //    if ((string)control.Tag == "platform")
                //    {
                //        control.Left += player.GetSpeed();
                //    }
                //}
                player.GetPlayer().Left -= player.GetSpeed();
            }

            if (input.IsKeyPressed(Keys.D))
            {
                //foreach (Control control in Controls)
                //{
                //    if ((string)control.Tag == "platform")
                //    {
                //        control.Left -= player.GetSpeed();
                //    }
                //}
                player.GetPlayer().Left += player.GetSpeed();
            }
        }

        private void yAxisMovementTimer_Tick(object sender, EventArgs e)
        {
            if (input.IsKeyPressed(Keys.Space))
            {
                // Move all platforms down during jump
                foreach (Control control in Controls)
                {
                    if ((string)control.Tag == "platform")
                    {
                        control.Top += player.GetSpeed();
                    }
                }
                player.SetJumping(true);
            }
            else
            {
                player.SetJumping(false);
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            input.SetKeyPressed(e.KeyCode);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            input.SetKeyReleased(e.KeyCode);

            if (!input.IsKeyPressed(Keys.A) || !input.IsKeyPressed(Keys.D))
            {
                xAxisMovementTimer.Stop();
            }
            else if (!input.IsKeyPressed(Keys.Space))
            {
                yAxisMovementTimer.Stop();
            }
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
