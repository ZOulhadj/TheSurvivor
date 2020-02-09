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

        public override void UpdateInternal()
        {
            // Move platform in the opposite direction if it hits the edge of the screen
            if (m_Platform.Location.X >= 930 - m_Platform.Width)
                movementDirection = MovementDirection.LEFT;
            else if (m_Platform.Location.X <= 0)
                movementDirection = MovementDirection.RIGHT;

            // Move the platform in a specific direction
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
