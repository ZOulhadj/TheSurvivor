using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheSurvivor.Source.World
{
    enum PlatformType
    {
        STATIC_PLATFORM,
        MOVING_PLATFORM,
    }

    struct PlatformSize
    {
        public Size size;

        public PlatformSize(int w, int h)
        {
            size = new Size(w, h);
        }
    }

    struct PlatformColor
    {
        public Color color;

        public PlatformColor(int red, int green, int blue)
        {
            color = Color.FromArgb(red, green, blue);
        }
    }

    struct PlatformPosition
    {
        public Point position;

        public PlatformPosition(int xpos, int ypos)
        {
            position = new Point(xpos, ypos);
        }
    }

    abstract class Platform
    {
        protected PictureBox m_Platform = new PictureBox();

        public PlatformSize     platformSize;
        public PlatformColor    platformColor;
        public PlatformPosition platformPosition;
        
        public bool m_Collision = false;

        public void Set()
        {
            m_Platform.Size = platformSize.size;
            m_Platform.BackColor = platformColor.color;
            m_Platform.Location = platformPosition.position;
            m_Platform.Tag = "platform";
        }

        public PictureBox Get()
        {
            return m_Platform;
        }

        public void Update(ref Player player)
        {
            // Update collision and transformations
            if (m_Platform.Bounds.IntersectsWith(player.GetPlayer().Bounds))
                m_Collision = true;
            else
                m_Collision = false;
            
            UpdateInternal();
        }

        public abstract void UpdateInternal();
    }
}
