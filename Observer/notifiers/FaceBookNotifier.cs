using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.notifiers
{
    class FaceBookNotifier : Observer
    {
        public FaceBookNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }
        public override void Notify(object args)
        {
            if (Subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via FACEBOOK with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tFile name: {2}", videoData.Title, videoData.Description, videoData.FileName);
            }
        }
    }
}