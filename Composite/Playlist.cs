using System;
using System.Collections.Generic;

namespace Composite
{
    class Playlist : IComponent
    {
        public string PlaylistName { get; set; }
        public List<IComponent> playlist = new List<IComponent>();
        public Playlist(string playlistName)
        {   
            PlaylistName = playlistName;
        }
        public string GetName()
        {
            return PlaylistName;
        }
        public void Add(IComponent component)
        {
            Console.WriteLine($"Add component {component.GetName()} to playlist {PlaylistName}");
            playlist.Add(component);
        }
        public void Remove(IComponent component)
        {
            Console.WriteLine($"Remove component {component.GetName()} from playlist {PlaylistName}");
            playlist.Remove(component);
        }
        public void Play()
        {
            Console.WriteLine($"Play playlist {PlaylistName} ...");
        }

        public void SetPlaySpeed(float speed)
        {
            foreach (IComponent component in playlist) {
                component.SetPlaySpeed(speed);
            }
        }
    }
}