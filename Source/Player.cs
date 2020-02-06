using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor.Source
{
    class Player
    {
        private Panel m_Player;
        private int m_PlayerSpeed = 10;
        public bool m_Collision = false;
        private bool m_IsJumping = false;

        public Input input = new Input();

        public Player(Panel player)
        {
            m_Player = player;
        }

        ~Player() {}


        public void SetJumping(bool isJumping) { m_IsJumping = isJumping; }

        public bool IsJumping() { return m_IsJumping; }

        public Panel GetPlayer() { return m_Player; }

        public int GetSpeed() { return m_PlayerSpeed; }
    }
}
