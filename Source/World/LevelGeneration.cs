using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using TheSurvivor.Forms;
using TheSurvivor.Source.Utilities;
using TheSurvivor.Source.World;

namespace TheSurvivor.Source
{
    class LevelGeneration
    {
        private Control.ControlCollection m_Controls;

        // m_Random seed generator used for generating m_Randomness and is used for
        // the platform locations.
        private Random m_Random = new Random();

        // Stores a list of different platform types that each have their own list
        // of platform information
        private Dictionary<PlatformType, List<Platform>> m_Platforms = new Dictionary<PlatformType, List<Platform>>();

        // Window dimensions (Hard coded values since the window will not be resizable)
        int width = 930, height = 790;

        // The number of platforms for each type (set in the generation stage)
        private int staticPlatformCount;
        private int movingPlatformCount;

        // The distance of the level in pixels going downward (+Y)
        private int m_LevelDistance = 20000;

        // This is used for determining when to reset and generate new platforms
        private int m_LevelOffset = 0;

        public LevelGeneration(Control.ControlCollection controls)
        {
            m_Controls = controls;
        }

        public void Generate()
        {
            // If generating platforms after a reset then remove all platforms for a fresh start
            if (m_Platforms.Count > 0)
                m_Platforms.Clear();

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
                case 5:
                    staticPlatformCount = Options.GetStaticPlatformCount();
                    movingPlatformCount = Options.GetMovingPlatformCount();
                    break;
            }

            // Generate platforms
            GeneratePlatform(PlatformType.STATIC_PLATFORM, staticPlatformCount, Color.Gold);
            GeneratePlatform(PlatformType.MOVING_PLATFORM, movingPlatformCount, Color.Cyan);

        }

        private void GeneratePlatform(PlatformType platformType, int platformCount, Color color)
        {
            List<Platform> platform = new List<Platform>(platformCount);
            Logging.Log(LogType.LOG, "Initialsing " + platformCount + " platforms");
            for (int i = 0; i < platformCount; ++i)
            {
                Platform platformObject = null;

                // Instantiate specific platform object based on what platform type will be generated
                switch (platformType)
                {
                    case PlatformType.STATIC_PLATFORM:
                        platformObject = new StaticPlatform();
                        break;
                    case PlatformType.MOVING_PLATFORM:
                        platformObject = new MovingPlatform();
                        break;
                }
                
                // Initialise platform settings
                platformObject.platformSize = new PlatformSize(50, 20);
                platformObject.platformColor = new PlatformColor(color.R, color.G, color.B);
                platformObject.platformPosition = new PlatformPosition(m_Random.Next(0, width - 50),
                                                            m_Random.Next(height, m_LevelDistance));

                // Push all initialised values to picturebox control
                platformObject.Set();


                // Add to moving platform list
                platform.Add(platformObject);

                // Add this picturebox control to the from control list 
                // for it to be rendered
                m_Controls.Add(platformObject.Get());
                        

            }

            m_Platforms.Add(platformType, platform);
        }
        int i = 1;
        public void Reset(Control.ControlCollection controls)
        {
            m_LevelOffset += Player.GetSpeed();

            if (m_LevelOffset >= m_LevelDistance)
            {
                foreach (Control controlItem in controls)
                {
                    if (controlItem.Tag == "platform")
                    {
                        // Note: Disposing the control on its own seems to not work sometimes.
                        // This is because it possibly does not have enough time to release
                        // the control before being redraw? To avoid a platform from being
                        // show when not meant to, simply make it not visible.

                        // TODO: Issue still occurs... (Only runs 50 times instead of 100)
                        Console.WriteLine("Disposing platform: " + i);
                        i += 1;
                        // TODO: Check if a hidden platform affects collision with the player
                        controlItem.BackColor = Color.Black;
                        controlItem.Visible = false;
                        controlItem.Dispose();
                    }
                }

                // Generate a new set of platforms
                Generate();

                // Send the background backwards so that the platforms are visible
                Control background = controls.Find("background", false).FirstOrDefault();
                background.SendToBack();

                // Reset level offset
                m_LevelOffset = 0;
            }
            
        }

        public Dictionary<PlatformType, List<Platform>> GetPlatforms()
        {
            return m_Platforms;
        }

    }
}
