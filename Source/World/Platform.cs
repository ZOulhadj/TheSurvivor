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

    // Interface for setting platform size
    struct PlatformSize
    {
        public Size size;

        public PlatformSize(int w, int h)
        {
            size = new Size(w, h);
        }
    }

    // Interface for setting platform color
    struct PlatformColor
    {
        public Color color;

        public PlatformColor(int r, int g, int b)
        {
            color = Color.FromArgb(r, g, b);
        }
    }

    // Interface for setting platform position
    struct PlatformPosition
    {
        public Point position;

        public PlatformPosition(int x, int y)
        {
            position = new Point(x, y);
        }
    }

    // Represents a platform i.e picturebox and is used for storing individual
    // data for each platform
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

        // Generic update method used for all platforms 
        public void Update(ref Player player)
        {
            // Update collision and transformations
            if (m_Platform.Bounds.IntersectsWith(player.GetPlayer().Bounds))
                m_Collision = true;
            else
                m_Collision = false;
            
            UpdateInternal();
        }

        // Platform specific update method. This is abstracted by each specific platform
        // and consits of specific updates performed, such as moving for the MovingPlatform
        public abstract void UpdateInternal();
    }
}
