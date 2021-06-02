using System;
using System.Threading;

namespace InterviewQuestions
{
    public class VideoEncoderDelegate
    {
        public static void Main()
        {
            Video video = new Video
            {
                Title = "Transformers"
            };
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            VideoEncoder videoEncoder = new VideoEncoder();
            videoEncoder.VideoEncoded += emailService.SendEmail;
            videoEncoder.VideoEncoded += smsService.SendSMS;
            videoEncoder.Encode(video);

        }

    }

    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object sender, EventArgs e);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding started...");
            Thread.Sleep(3000);
            Console.WriteLine($"The video with title {video.Title} is encoded");

            OnVideoEncoded();

            // Using event and delegates we do not need to modify this class when a new service like email or sms get added.
            // Send Email

            // Send SMS
        }

        private void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
    public class Video
    {
        public string Title { get; set; }
    }

    public class EmailService
    {
        public void SendEmail(object sender, EventArgs e)
        {
            Console.WriteLine("Email Sent");
        }
    }

    public class SMSService
    {
        public void SendSMS(object sender, EventArgs e)
        {
            Console.WriteLine("SMS Sent");
        }
    }
}
