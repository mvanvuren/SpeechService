using Topshelf;

namespace SpeechService
{
    public class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.UseLinuxIfAvailable();
                x.Service<NancySelfHost>(s =>
                {
                    s.ConstructUsing(name => new NancySelfHost());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("Speech Service");
                x.SetDisplayName("Speech Service");
                x.SetServiceName("Speech Service");
            });
        }
    }
}