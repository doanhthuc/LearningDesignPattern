using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class VideoData : Subject
    {
        #region Private properties
        private string title;
        private string description;
        private string fileName;

        #endregion
        public string Title
        {
            get => title;
            set
            {
                title = value;
                VideoDataChanged();
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                VideoDataChanged();
            }
        }
        public string FileName
        {
            get => fileName;
            set
            {
                fileName = value;
                VideoDataChanged();
            }
        }
        private void VideoDataChanged()
        {
            NotifyObserver(null);
        }
        private void domethod() { }
    }
}