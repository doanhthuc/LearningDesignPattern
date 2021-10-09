using System;

namespace Observer.notifiers
{
    class PhoneNotifier : Observer
    {
        public PhoneNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }
        public override void Notify(object args)
        {
            if (Subject is VideoData videoData) {
                Console.WriteLine("Notify all subscribers via PHONE NUMBER with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tFile name: {2}", videoData.Title, videoData.Description, videoData.FileName);
            }
        }
    }
}