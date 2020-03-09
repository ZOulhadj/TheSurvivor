using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TheSurvivor.Forms;

namespace TheSurvivor.Source
{
    class Player
    {
        private Panel m_Player;
        private static int m_PlayerSpeed;
        public bool m_Collision = false;
        private bool m_IsJumping = false;

        public Player(Panel player)
        {
            m_Player = player;

            // Change player speed based on difficulty set in the options menu
            switch (Options.GetDifficulty())
            {
                case 1:
                    m_PlayerSpeed = 10;
                    break;
                case 2:
                    m_PlayerSpeed = 20;
                    break;
                case 3:
                    m_PlayerSpeed = 30;
                    break;
                case 4:
                    m_PlayerSpeed = 40;
                    break;
                case 5:
                    m_PlayerSpeed = Options.GetPlayerSpeed();
                    break;
            }
        }

        ~Player() {}

        public void SetJumping(bool isJumping) { m_IsJumping = isJumping; }

        public bool IsJumping() { return m_IsJumping; }

        public Panel GetPlayer() { return m_Player; }

        public static int GetSpeed() { return m_PlayerSpeed; }
    }
}
