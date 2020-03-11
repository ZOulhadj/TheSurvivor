using System;
using System.Windows.Media;

using TheSurvivor.Forms;
using TheSurvivor.Source.Utilities;

namespace TheSurvivor.Source.Music
{
    class Sound
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private bool m_IsMusicEnabled;
        
        public Sound(string filePath)
        {
            // Load sound file
            Logging.Log(LogType.LOG, "Loading sound asset located at: " + filePath);
            mediaPlayer.Open(new Uri(filePath));

            // If soundtrack is not found then print an error
            mediaPlayer.MediaFailed += (o, args) =>
            {
                Logging.Log(LogType.ERROR, "Failed to load sound asset");
            };

            // Set soundtrack volume
            mediaPlayer.Volume = 0.05;

            // Find out if the sound option is selected
            if (Options.GetMusicSetting())
                m_IsMusicEnabled = true;
            else
                m_IsMusicEnabled = false;
        }

        ~Sound()
        {}

        public void Play()
        {
            if (m_IsMusicEnabled)
            {
                mediaPlayer.Play();
                Logging.Log(LogType.LOG, "Playing sound");
            }
            else
            {
                Logging.Log(LogType.WARNING, "Not playing sound, [Reason]: Sound disabled in the options");
            }
        }

        public void Pause()
        {
            mediaPlayer.Pause();
        }

        public void Stop()
        {
            mediaPlayer.Stop();
        }
    }
}
