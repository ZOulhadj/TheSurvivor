using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class GameForm : Form
    {
        bool isJumping = false;

        public GameForm()
        {
            InitializeComponent();
        }

        private void gravityTimer_Tick(object sender, EventArgs e)
        {
            if (!player.Bounds.IntersectsWith(ground.Bounds) && isJumping == false)
            {
                player.Top += 10;
            }
        }

        private void upTimer_Tick(object sender, EventArgs e)
        {
            player.Top -= 10;
            isJumping = true;
        }

        private void rightTimer_Tick(object sender, EventArgs e)
        {
            player.Left += 10;
        }

        private void leftTimer_Tick(object sender, EventArgs e)
        {
            player.Left -= 10;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle player input
            switch (e.KeyCode)
            {
                case Keys.W:
                    upTimer.Start();
                    break;
                case Keys.A:
                    leftTimer.Start();
                    break;
                case Keys.D:
                    rightTimer.Start();
                    break;
            }

        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            // Handle player input
            switch (e.KeyCode)
            {
                case Keys.W:
                    upTimer.Stop();
                    isJumping = false;
                    break;
                case Keys.A:
                    leftTimer.Stop();
                    break;
                case Keys.D:
                    rightTimer.Stop();
                    break;
            }
        }
    }
}
