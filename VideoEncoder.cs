using System;
using System.Threading;

namespace Events_Delegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1- Define a delegate -- Video Encoded Event Handler
        //2- Define an event based on that delegate
        //3- Raise the event


        //Same as next statement --- so we do not have to explicitly create an EventHandler (Don't re-invent the wheel)
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //EventHandler
        //EventHandler<TEventArgs>



        public event EventHandler<VideoEventArgs> VideoEncoded;
        


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() {Video = video});

            // Same Code Below
            /* if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
            */
        }
        }
}