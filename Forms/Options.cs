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

        public Options()
        {
            InitializeComponent();

            // Disables form movement
            FormBorderStyle = FormBorderStyle.None;
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

            // Select player image
            if (bomberOption.Checked)
                m_PlayerImage = Properties.Resources.Bomber;
            else if (explorerOption.Checked)
                m_PlayerImage = Properties.Resources.Explorer;
            else if (fighterOption.Checked)
                m_PlayerImage = Properties.Resources.Fighter;
            else if (rangerOption.Checked)
                m_PlayerImage = Properties.Resources.Ranger;



            Hide();
        }

        static public Bitmap GetPlayerImage()
        {
            return m_PlayerImage;
        }
    }
}
