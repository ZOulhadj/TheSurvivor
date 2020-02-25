using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TheSurvivor.Source.Music
{
    class Sound
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        
        public Sound(string filePath)
        {
            mediaPlayer.Open(new Uri(filePath));
            mediaPlayer.Volume = 0.01;
        }

        public void Play()
        {
            mediaPlayer.Play();
        }

        public void Stop()
        {
            mediaPlayer.Stop();
        }
    }
}
