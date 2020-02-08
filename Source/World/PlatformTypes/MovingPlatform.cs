using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheSurvivor.Source.World
{
    enum MovementDirection
    {
        LEFT = 0,
        RIGHT = 1
    }

    class MovingPlatform : Platform
    {
        private int m_MovementSpeed = 1;

        public MovementDirection movementDirection;

        public override void Update()
        {
            switch (movementDirection)
            {
            case MovementDirection.RIGHT:
                m_Platform.Location = new Point(m_Platform.Location.X + m_MovementSpeed,
                                                m_Platform.Location.Y);
                    break;
            case MovementDirection.LEFT:
                m_Platform.Location = new Point(m_Platform.Location.X - m_MovementSpeed,
                                                m_Platform.Location.Y);
                    break;
            }
        }
    }
}
