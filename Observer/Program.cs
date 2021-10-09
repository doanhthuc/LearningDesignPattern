using System;
using Observer.notifiers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            var emailNotifier = new EmailNotifier(videoData);
            var phoneNotifier = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.Title = "Observer Design Pattern";

            videoData.DetachObserver(youtubeNotifier);
            Console.WriteLine("--------------------------------------------");
            videoData.Description = "Video's Description";
            
            var _ = new FaceBookNotifier(videoData);
            Console.WriteLine("--------------------------------------------");
            videoData.FileName = "Good video!!!";
        }
    }
}
