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
        private static Bitmap m_PlayerImage = Properties.Resources.Bomber;
        private static bool m_Music = true;
        private static int m_Difficulty = 1;
        private static int m_StaticPlatformCount;
        private static int m_MovingPlatformCount;
        private static int m_PlayerSpeed;

        public Options()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            // Select player image
            if (bomberOption.Checked)
                m_PlayerImage = Properties.Resources.Bomber;
            else if (explorerOption.Checked)
                m_PlayerImage = Properties.Resources.Explorer;
            else if (fighterOption.Checked)
                m_PlayerImage = Properties.Resources.Fighter;
            else if (rangerOption.Checked)
                m_PlayerImage = Properties.Resources.Ranger;


            // Set difficulty
            m_Difficulty = difficultySlider.Value;

            // If slider option is custom then set custom values
            if (difficultySlider.Value == 5)
            {
                m_StaticPlatformCount   = int.Parse(staticPlatformsTextbox.Text);
                m_MovingPlatformCount   = int.Parse(movingPlatformsTextbox.Text);
                m_PlayerSpeed           = int.Parse(playerSpeedTextbox.Text);
            }


            Hide();
        }

        private void difficultySlider_Scroll(object sender, EventArgs e)
        {
            // Change visibility based the difficulty slider setting
            if (difficultySlider.Value == 5)
            {
                staticPlatformsLabel.Visible = true;
                staticPlatformsTextbox.Visible = true;

                movingPlatformsTextbox.Visible = true;
                movingPlatformsLabel.Visible = true;

                playerSpeedLabel.Visible = true;
                playerSpeedTextbox.Visible = true;

                performanceWarningLabel.Visible = true;
            }
            else
            {
                staticPlatformsLabel.Visible = false;
                staticPlatformsTextbox.Visible = false;

                movingPlatformsTextbox.Visible = false;
                movingPlatformsLabel.Visible = false;

                playerSpeedLabel.Visible = false;
                playerSpeedTextbox.Visible = false;

                performanceWarningLabel.Visible = false;

            }
        }


        private void toggleMusicButton_Click(object sender, EventArgs e)
        {
            if (toggleMusicLabel.Text == "On")
            {
                toggleMusicLabel.Text = "Off";
                toggleMusicLabel.ForeColor = Color.Red;
                m_Music = false;
            }
            else if (toggleMusicLabel.Text == "Off")
            {
                toggleMusicLabel.Text = "On";
                toggleMusicLabel.ForeColor = Color.Green;
                m_Music = true;
            }
        }


        static public Bitmap GetPlayerImage()
        {
            return m_PlayerImage;
        }

        static public int GetDifficulty()
        {
            return m_Difficulty;
        }

        static public int GetStaticPlatformCount()
        {
            return m_StaticPlatformCount;
        }

        static public int GetMovingPlatformCount()
        {
            return m_MovingPlatformCount;
        }

        static public int GetPlayerSpeed()
        {
            return m_PlayerSpeed;
        }

        static public bool GetMusicSetting()
        {
            if (m_Music)
                return true;
            else
                return false;
        }

    }
}
