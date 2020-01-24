using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSurvivor.Source
{
    class Player
    {
        private int playerSpeed = 10;

        public Player()
        {
            
            //p.Location = new System.Drawing.Point(150, 473);
            //p.Name = "object";
            //p.Size = new System.Drawing.Size(playerSize.Item1, playerSize.Item2);
            //p.TabIndex = 4;
        }

        public int GetPlayerSpeed()
        {
            return playerSpeed;
        }

        public Panel GetPlayer()
        {
            //return p;
            return new Panel();
        }
    }
}
