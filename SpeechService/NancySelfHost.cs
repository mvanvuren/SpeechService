using System;
using Nancy.Hosting.Self;

namespace SpeechService
{
    public class NancySelfHost
    {
        NancyHost _nancyHost;

        public void Start()
        {
            _nancyHost = new NancyHost(new Uri("http://localhost:5000"));
            _nancyHost.Start();

        }

        public void Stop()
        {
            _nancyHost.Stop();
            Console.WriteLine("Stopped. Good bye!");
        }
    }
}