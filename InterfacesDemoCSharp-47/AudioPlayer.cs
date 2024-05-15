using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_47
{
    public class AudioPlayer : IMediaPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Audio is paused..");
        }

        public void Play()
        {
            Console.WriteLine("Audio is playing..");
        }

        public void Stop()
        {
            Console.WriteLine("Audio is stopped..");
        }
    }
}
