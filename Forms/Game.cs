using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;

using TheSurvivor.Source;
using TheSurvivor.Source.World;

namespace TheSurvivor
{
    /* This is the main game form which consits of initialisation of sub components,
     * the main game loop etc.
     */
    public partial class Game : Form
    {
        // Random seed generator used for generating randomness and is used for
        // the platform locations.
        Random random = new Random();

        // An instance of the player
        Player player;
        
        Input input = new Input();
        
        // Stores a list of different platform types that each have their own list
        // of platform information.
        Dictionary<PlatformType, List<Platform>> m_Platforms = new Dictionary<PlatformType, List<Platform>>();

        List<PictureBox> m_Hearts = new List<PictureBox>();
        
        // Basic game settings
        int staticPlatformCount = 50;
        int movingPlatformCount = 50;

        // The distance of the level in pixels
        int levelDistance = 20000;

        int lives = 3;

        // The score required to win the game
        int victoryScore = 2000;

        bool first = true;
        bool isDead = false;
        bool victory = false;

        // Used to play soundtracks
        MediaPlayer backgroundMusic = new MediaPlayer();
        MediaPlayer victoryMusic = new MediaPlayer();

        public Game()
        {
            InitializeComponent();

            // Start playing background music
            backgroundMusic.Open(new Uri("E:\\Programming\\TheSurvivor\\Assets\\Sounds\\Soundtrack.wav"));
            backgroundMusic.Volume = 0.05;
            //backgroundMusic.Play();

            // Initialise sub components
            {
                // Initialise differnet platforms
                
                List<Platform> staticPlatforms = new List<Platform>(staticPlatformCount);
                for (int i = 0; i < staticPlatformCount; ++i)
                {
                    // Initialise moving platform
                    StaticPlatform sp = new StaticPlatform();
                    sp.platformSize = new PlatformSize(50, 20);
                    sp.platformColor = new PlatformColor(0, 255, 0);
                    sp.platformPosition = new PlatformPosition(random.Next(100, ClientSize.Width - 100),
                                                               random.Next(ClientSize.Height - 100, levelDistance));

                    // Push all initialised values to picturebox control
                    sp.Set();

                    // Add this picturebox control to the from control list 
                    // for it to be rendered
                    Controls.Add(sp.Get());

                    // Add to moving platform list
                    staticPlatforms.Add(sp);
                }

                List<Platform> movingPlatforms = new List<Platform>(movingPlatformCount);
                for (int i = 0; i < movingPlatformCount; ++i)
                {
                    // Initialise moving platform
                    MovingPlatform mp = new MovingPlatform();
                    mp.platformSize = new PlatformSize(50, 20);
                    mp.platformColor = new PlatformColor(255, 60, 120);
                    mp.platformPosition = new PlatformPosition(random.Next(100, ClientSize.Width - 100),
                                                               random.Next(ClientSize.Height - 100, levelDistance));
                    mp.movementDirection = (MovementDirection)random.Next(0, 2);

                    // Push all initialised values to picturebox control
                    mp.Set();

                    // Add this picturebox control to the from control list 
                    // for it to be rendered
                    Controls.Add(mp.Get());

                    // Add to moving platform list
                    movingPlatforms.Add(mp);
                }


                // Add moving platform to platform list
                m_Platforms.Add(PlatformType.STATIC_PLATFORM, staticPlatforms);
                m_Platforms.Add(PlatformType.MOVING_PLATFORM, movingPlatforms);


                // Initialise player
                player = new Player(playerControl);
                player.GetPlayer().SendToBack();

                // Send the background backwards so that the platforms are visible
                background.SendToBack();

                // Initialise hearts
                m_Hearts.Add(heart1);
                m_Hearts.Add(heart2);
                m_Hearts.Add(heart3);
            }
        }

        ~Game()
        {
            backgroundMusic.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Pause the game initially
            if (first)
            {
                Thread.Sleep(200);
                first = false;
            }

            // For each platform type, update them
            foreach (KeyValuePair<PlatformType, List<Platform>> platformType in m_Platforms)
            {
                platformType.Value.ForEach(platform =>
                {
                    // For each platform check if a collision has occured
                    if (!platform.m_Collision)
                    {
                        platform.Get().Top -= player.GetSpeed();
                    }
                    else
                    {
                        // TODO: Fix possible collision issue
                        UpdateLives();
                    }

                    // Update each platform type
                    platform.Update(ref player);
                });
            }

            // Player movement
            if (input.IsKeyPressed(Keys.A) || input.IsKeyPressed(Keys.D))
                xAxisMovementTimer.Start();


            // Increment score by a certain value each time
            GameInformation.currentScore++;
            if (GameInformation.currentScore >= GameInformation.previousScore + 50)
            {
                GameInformation.previousScore = GameInformation.currentScore;
                scoreLabel.Text = "Score: " + GameInformation.currentScore.ToString();
            }


            // Fuel
            //playerFuel.Value--;


            // Victory
            if (GameInformation.currentScore >= victoryScore && !victory)
            {
                victoryMusic.Open(new Uri("E:\\Programming\\TheSurvivor\\Assets\\Sounds\\Victory.wav"));
                victoryMusic.Volume = 0.2;
                victoryMusic.Play();

                victory = true;
            }

            // If the player dies then show the death screen
            if (isDead)
            {
                Close();
                Forms.DeathScreen ds = new Forms.DeathScreen();
                ds.Show();
            }

        }

        private void xAxisMovementTimer_Tick(object sender, EventArgs e)
        {
            // Ensure player is within the window
            if (player.GetPlayer().Location.X >= ClientSize.Width - player.GetPlayer().Width)
                player.GetPlayer().Location = new Point(ClientSize.Width - player.GetPlayer().Width, player.GetPlayer().Location.Y);
            else if (player.GetPlayer().Location.X <= 0)
                player.GetPlayer().Location = new Point(0, player.GetPlayer().Location.Y);

            // Move player on the X axis
            if (input.IsKeyPressed(Keys.A))
                player.GetPlayer().Left -= player.GetSpeed();

            if (input.IsKeyPressed(Keys.D))
                player.GetPlayer().Left += player.GetSpeed();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            input.SetKeyPressed(e.KeyCode);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            input.SetKeyReleased(e.KeyCode);

            if (!input.IsKeyPressed(Keys.A) || !input.IsKeyPressed(Keys.D))
                xAxisMovementTimer.Stop();
        }

        private void UpdateLives()
        {
            // Play hit sound


            //lives 
            // Remove heart from game
            m_Hearts[lives - 1].Dispose();

            // Decrease life value
            lives--;

            // Reset if still alive, else the player dies
            if (lives >= 1)
            {
                // 'Move' controls down 1000 pixels as a way of resetting
                foreach (KeyValuePair<PlatformType, List<Platform>> reset in m_Platforms)
                {
                    reset.Value.ForEach(p =>
                    {
                        p.Get().Location = new Point(p.Get().Location.X, p.Get().Location.Y + 1000);
                    });
                };
                Thread.Sleep(2000);
            }
            else
            {
                // If no hearts remain then they are dead
                isDead = true;
            }
        }





        private void btnContinue_Click(object sender, EventArgs e)
        {
            // TODO: Fix input not working after clicking continue
            pausePanel.Visible = false;
            //isPaused = false;
        }
        
        private void btnOptions_Click(object sender, EventArgs e)
        {
            Forms.Options options = new Forms.Options();

            options.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

    /* The player score information is stored in a static class because it has
     * to be accessed from within the death screen.
     */
    public static class GameInformation
    {
        public static int previousScore = 0, currentScore = 0;
    }


}
