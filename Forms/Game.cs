using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
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

            // Fixes flickering
            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            SoundPlayer soundTrack = new SoundPlayer(@"C:/Users/zakar/Downloads/test.wav");
            //soundTrack.Play();

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
            if (playerObject.Location.X >= Width)
                playerObject.Location = new Point(Width, playerObject.Location.Y);
            
            foreach (Control control in Controls)
            {
                if (control.Tag == "platform" && isJumping == false)
                {
                    if (playerObject.Bounds.IntersectsWith(control.Bounds))
                    {
                        playerObject.Top -= 1 * player.GetPlayerSpeed();
                    }
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

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
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

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
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
            pausePanel.Visible = false;
            isPaused = false;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    // Note: Fixes flickering
    internal static class NativeWinAPI
    {
        internal static readonly int GWL_EXSTYLE = -20;
        internal static readonly int WS_EX_COMPOSITED = 0x02000000;

        [DllImport("user32")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
    }
}
