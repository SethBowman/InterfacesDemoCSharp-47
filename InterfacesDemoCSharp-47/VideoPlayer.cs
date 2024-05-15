using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoCSharp_47
{
    public class VideoPlayer : IMediaPlayer
    {
        public void Pause()
        {
            Console.WriteLine("Video is paused..");
        }

        public void Play()
        {
            Console.WriteLine("Video is playing..");
        }

        public void Stop()
        {
            Console.WriteLine("Video is stopped..");
        }
    }
}
