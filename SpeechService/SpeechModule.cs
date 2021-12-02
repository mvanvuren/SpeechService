using System;
using System.Speech.Synthesis;
using Nancy;
using Nancy.ModelBinding;

namespace SpeechService
{
    public class SpeechModule : NancyModule
    {
        public SpeechModule()
        {
            var synth = new SpeechSynthesizer();

            synth.SpeakStarted += SynthOnSpeakStarted;
            synth.SpeakCompleted += SynthOnSpeakCompleted;

            Post["/"] = _ =>
            {
                var model = this.Bind<Model>();

                var startTime = DateTime.Now;
                synth.Speak(model.Text);
                Console.WriteLine(model.Text);
                var endTime = DateTime.Now;

                var responseSpeech = new ResponseSpeech
                {
                    Id = model.Id,
                    Status = "OK",
                    StartTime = new DateTimeOffset(startTime).ToUnixTimeMilliseconds(),
                    Duration = (long) (endTime - startTime).TotalMilliseconds
                };

                return Response.AsJson(responseSpeech);
            };
        }

        static void SynthOnSpeakStarted(object sender, SpeakStartedEventArgs speakStartedEventArgs)
        {
            
        }

        static void SynthOnSpeakCompleted(object sender, SpeakCompletedEventArgs speakCompletedEventArgs)
        {
        }

    }
}