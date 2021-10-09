using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make new empty "Study" playlist
            Playlist studyPlaylist = new Playlist("Study");

            // Make "Synth Pop" playlist and add 2 songs to it
            Playlist synthPopPlaylist = new Playlist("Synth Pop");
            Song synthPopSong1 = new Song("Girl Like You", "Marooon 5");
            Song synthPopSong2 = new Song("Outside", "TOPS");
            synthPopPlaylist.Add(synthPopSong1);
            synthPopPlaylist.Add(synthPopSong2);

            // Make "Experimental" playlist and add 3 songs to it, 
            // then set playback speed of the playlist to 0.5x
            Playlist experimentalPlaylist = new Playlist("Experimental");
            Song experimentalSong1 = new Song("About you", "XXYYXX");
            Song experimentalSong2 = new Song("Motivation", "Clams Casino");
            Song experimentalSong3 = new Song("Computer Vision", "Oneohtrix Point Never");
            experimentalPlaylist.Add(experimentalSong1);
            experimentalPlaylist.Add(experimentalSong2);
            experimentalPlaylist.Add(experimentalSong3);
            float slowSpeed = 0.5f;
            experimentalPlaylist.SetPlaySpeed(slowSpeed);

            // Add the "Synth Pop" playlist to the "Experimental" playlist
            experimentalPlaylist.Add(synthPopPlaylist);

            // Add the "Experimental" playlist to the "Study" playlist
            studyPlaylist.Add(experimentalPlaylist);

            // Create a new song and set its playback speed to 1.25x, play this song, 
            // get the name of glitchSong → "Textuell", then get the artist of this song → "Oval"
            Song glitchSong = new Song("Textuell", "Oval");
            float fasterSpeed = 1.25f;
            glitchSong.SetPlaySpeed(fasterSpeed);
            glitchSong.Play();
            String name = glitchSong.GetName();
            String artist = glitchSong.Artist;
            Console.WriteLine("The song name is " + name);
            Console.WriteLine("The song artist is " + artist);
        }
    }
}
