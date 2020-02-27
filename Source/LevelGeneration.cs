using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Windows.Forms;

using TheSurvivor.Source.World;
using TheSurvivor.Source.Utilities;
using TheSurvivor.Forms;

namespace TheSurvivor.Source
{
    class LevelGeneration
    {
        // m_Random seed generator used for generating m_Randomness and is used for
        // the platform locations.
        private Random m_Random = new Random();

        // Stores a list of different platform types that each have their own list
        // of platform information
        private Dictionary<PlatformType, List<Platform>> m_Platforms = new Dictionary<PlatformType, List<Platform>>();

        // Window dimensions (Hard coded values since the window will not be resizable
        int width = 476, height = 493;

        // Basic game settings
        private int staticPlatformCount;
        private int movingPlatformCount;

        // The distance of the level in pixels
        int levelDistance = 20000;

        public void Generate(Control.ControlCollection controls)
        {
            // Change the amount of platforms generated based on difficulty
            switch (Options.GetDifficulty())
            {
            case 1:
                    staticPlatformCount = 50;
                    movingPlatformCount = 50;
                    break;
            case 2:
                    staticPlatformCount = 65;
                    movingPlatformCount = 65;
                    break;
            case 3:
                    staticPlatformCount = 80;
                    movingPlatformCount = 80;
                    break;
            case 4:
                    staticPlatformCount = 100;
                    movingPlatformCount = 100;
                    break;
            }

            List<Platform> staticPlatforms = new List<Platform>(staticPlatformCount);

            Logging.Log(LogType.LOG, "Initialsing " + staticPlatformCount + " static platforms");
            for (int i = 0; i < staticPlatformCount; ++i)
            {
                // Initialise moving platform
                StaticPlatform sp = new StaticPlatform();
                sp.platformSize = new PlatformSize(50, 20);
                sp.platformColor = new PlatformColor(0, 255, 0);
                sp.platformPosition = new PlatformPosition(m_Random.Next(0, width - 100),
                                                           m_Random.Next(height + 500, levelDistance));

                // Push all initialised values to picturebox control
                sp.Set();

                // Add this picturebox control to the from control list 
                // for it to be rendered
                controls.Add(sp.Get());

                // Add to moving platform list
                staticPlatforms.Add(sp);
            }


            List<Platform> movingPlatforms = new List<Platform>(movingPlatformCount);

            Logging.Log(LogType.LOG, "Initialsing " + movingPlatformCount + " moving platforms");
            for (int i = 0; i < movingPlatformCount; ++i)
            {
                // Initialise moving platform
                MovingPlatform mp = new MovingPlatform();
                mp.platformSize = new PlatformSize(50, 20);
                mp.platformColor = new PlatformColor(255, 60, 120);
                mp.platformPosition = new PlatformPosition(m_Random.Next(0, width - 100),
                                                           m_Random.Next(height + 500, levelDistance));
                mp.movementDirection = (MovementDirection)m_Random.Next(0, 2);

                // Push all initialised values to picturebox control
                mp.Set();

                // Add this picturebox control to the from control list 
                // for it to be rendered
                controls.Add(mp.Get());

                // Add to moving platform list
                movingPlatforms.Add(mp);
            }


            // Add moving platform to platform list
            m_Platforms.Add(PlatformType.STATIC_PLATFORM, staticPlatforms);
            m_Platforms.Add(PlatformType.MOVING_PLATFORM, movingPlatforms);
        }
    
        
        public Dictionary<PlatformType, List<Platform>> GetPlatforms()
        {
            return m_Platforms;
        }

    }
}
