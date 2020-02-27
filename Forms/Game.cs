using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using TheSurvivor.Source;
using TheSurvivor.Forms;
using TheSurvivor.Source.Utilities;
using TheSurvivor.Source.Music;
using TheSurvivor.Source.World;

namespace TheSurvivor
{
    /* This is the main game form which consits of initialisation of sub components,
     * the main game loop etc.
     */
    public partial class Game : Form
    {

        // An instance of the player
        Player m_Player;
        Input m_Input = new Input();
        LevelGeneration m_Level = new LevelGeneration();
        List<PictureBox> m_Hearts = new List<PictureBox>();
        
        int lives = 3;

        // The score required to win the game
        int victoryScore = 2000;

        bool isDead = false;
        bool victory = false;

        // Initialise music
        Sound backgroundMusic;
        Sound victoryMusic;

        public Game()
        {
            InitializeComponent();

            // Initialise sound tracks
            Logging.Log(LogType.LOG, "Initialsing soundtracks");
            backgroundMusic = new Sound(FileSystem.GetAsset("Sounds/Soundtrack.wav"));
            victoryMusic = new Sound(FileSystem.GetAsset("Sounds/Victory.wav"));
            
            // Initialise differnet platforms
            Logging.Log(LogType.LOG, "Initialsing level");
            m_Level.Generate(Controls);

            // Initialise player
            Logging.Log(LogType.LOG, "Initialsing player");
            m_Player = new Player(playerControl);
            m_Player.GetPlayer().BackgroundImage = Options.GetPlayerImage();
            m_Player.GetPlayer().SendToBack();

            // Send the background backwards so that the platforms are visible
            background.SendToBack();

            // Initialise hearts
            Logging.Log(LogType.LOG, "Populating heart array");
            m_Hearts.Add(heart1);
            m_Hearts.Add(heart2);
            m_Hearts.Add(heart3);



            // Start playing the soundtrack
            backgroundMusic.Play();

        }

        ~Game()
        {  
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // For each platform type, update them
            foreach (KeyValuePair<PlatformType, List<Platform>> platformType in m_Level.GetPlatforms())
            {
                platformType.Value.ForEach(platform =>
                {
                    // For each platform check if a collision has occured
                    if (!platform.m_Collision)
                    {
                        platform.Get().Top -= m_Player.GetSpeed();
                    }
                    else
                    {
                        // TODO: Fix possible collision issue
                        UpdateLives();
                    }

                    // Update each platform type
                    platform.Update(ref m_Player);
                });
            }

            // Player movement
            if (m_Input.IsKeyPressed(Keys.A) || m_Input.IsKeyPressed(Keys.D))
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
                victoryMusic.Play();
                victory = true;
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

        }

        private void xAxisMovementTimer_Tick(object sender, EventArgs e)
        {
            // Ensure player is within the window
            if (m_Player.GetPlayer().Location.X >= ClientSize.Width - m_Player.GetPlayer().Width)
                m_Player.GetPlayer().Location = new Point(ClientSize.Width - m_Player.GetPlayer().Width, m_Player.GetPlayer().Location.Y);
            else if (m_Player.GetPlayer().Location.X <= 0)
                m_Player.GetPlayer().Location = new Point(0, m_Player.GetPlayer().Location.Y);

            // Move player on the X axis
            if (m_Input.IsKeyPressed(Keys.A))
                m_Player.GetPlayer().Left -= m_Player.GetSpeed();

            if (m_Input.IsKeyPressed(Keys.D))
                m_Player.GetPlayer().Left += m_Player.GetSpeed();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            m_Input.SetKeyPressed(e.KeyCode);
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            m_Input.SetKeyReleased(e.KeyCode);

            if (!m_Input.IsKeyPressed(Keys.A) || !m_Input.IsKeyPressed(Keys.D))
                xAxisMovementTimer.Stop();
        }

        private void UpdateLives()
        {
            // TODO: Play hit sound


            //lives 
            // Remove heart from game
            m_Hearts[lives - 1].Dispose();

            // Decrease life value
            lives--;

            // Reset if still alive, else the player dies
            if (lives >= 1)
            {
                // 'Move' controls down 1000 pixels as a way of resetting
                foreach (KeyValuePair<PlatformType, List<Platform>> reset in m_Level.GetPlatforms())
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





        private void btnContinue_Click(object sender, EventArgs e)
        {
            // TODO: Fix input not working after clicking continue
            pausePanel.Visible = false;
            //isPaused = false;
        }
        
        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options options = new Forms.Options();

            options.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundMusic.Stop();
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
