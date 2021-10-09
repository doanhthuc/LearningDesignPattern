using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Song : IComponent
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public float Speed { get; set; } = 1;
        public Song(string songName, string artist)
        {
            SongName = songName;
            Artist = artist;
        }
        public string GetName()
        {
            return SongName;
        }
        public void Play()
        {
            Console.WriteLine($"Play {SongName} with speed {Speed}...");
        }

        public void SetPlaySpeed(float speed)
        {
            Speed = speed;
            Console.WriteLine($"Set Song {SongName} to speed {Speed}");
        }
    }
}