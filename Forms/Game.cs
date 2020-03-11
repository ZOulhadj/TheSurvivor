using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TheSurvivor.Forms;
using TheSurvivor.Source;
using TheSurvivor.Source.Music;
using TheSurvivor.Source.Utilities;
using TheSurvivor.Source.World;

namespace TheSurvivor
{
    /* This is the main game form which consits of initialisation of sub components,
     * the main game loop etc.
     */
    public partial class Game : Form
    {

        // An instance of the player
        Player player;
        Input input = new Input();
        LevelGeneration level;
        List<PictureBox> hearts = new List<PictureBox>();
        
        int lives = 3;

        bool isDead = false;

        // Initialise music
        Sound backgroundMusic;

        public Game()
        {
            InitializeComponent();

            // Initialise sound tracks
            Logging.Log(LogType.LOG, "Initialsing soundtracks");
            backgroundMusic = new Sound(FileSystem.GetAsset("Sounds/Soundtrack.wav"));
            
            // Initialise differnet platforms
            Logging.Log(LogType.LOG, "Initialsing level");
            level = new LevelGeneration(Controls);
            level.Generate();

            // Initialise player
            Logging.Log(LogType.LOG, "Initialsing player");
            player = new Player(playerControl);
            player.GetPlayer().BackgroundImage = Options.GetPlayerImage();
            player.GetPlayer().SendToBack();

            // Send the background backwards so that the platforms are visible
            background.SendToBack();

            // Initialise hearts
            Logging.Log(LogType.LOG, "Populating heart array");
            hearts.Add(heart1);
            hearts.Add(heart2);
            hearts.Add(heart3);

            // Start playing the soundtrack
            backgroundMusic.Play();

        }

        ~Game()
        {}

        // Main update loop
        private void timer_Tick(object sender, EventArgs e)
        {
            // For each platform type, update them
            foreach (KeyValuePair<PlatformType, List<Platform>> platformType in level.GetPlatforms())
            {
                platformType.Value.ForEach(platform =>
                {
                    // For each platform check if a collision has occured
                    if (!platform.m_Collision)
                    {
                        platform.Get().Top -= Player.GetSpeed();
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

            // If the player dies then show the death screen
            if (isDead)
            {
                backgroundMusic.Stop();
                Close();
                DeathScreen ds = new Forms.DeathScreen();
                ds.Show();

                Logging.Log(LogType.WARNING, "Closing game and displaying death screen [Reason]: Player has died");
            }


            // Resets the platforms if the player has travelled a certain amount making the game go on forever
            level.Reset();
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
                player.GetPlayer().Left -= Player.GetSpeed();

            if (input.IsKeyPressed(Keys.D))
                player.GetPlayer().Left += Player.GetSpeed();
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
            //lives 
            // Remove heart from game
            hearts[lives - 1].Dispose();

            // Decrease life value
            lives--;

            // Reset if still alive, else the player dies
            if (lives >= 1)
            {
                // 'Move' controls down 1000 pixels as a way of resetting
                foreach (KeyValuePair<PlatformType, List<Platform>> reset in level.GetPlatforms())
                {
                    reset.Value.ForEach(p =>
                    {
                        p.Get().Location = new Point(p.Get().Location.X, p.Get().Location.Y + 1500);
                    });
                };

                Logging.Log(LogType.WARNING, "Resetting position [Reason]: Player collision detected");
                backgroundMusic.Pause();
                Thread.Sleep(1500);
                backgroundMusic.Play();
            }
            else
            {
                // If no hearts remain then they are dead
                isDead = true;
            }
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
