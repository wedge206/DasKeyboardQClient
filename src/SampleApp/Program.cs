namespace SampleApp
{
    using System;
    using Wedge.DasKeyboardQClient;
    using Wedge.DasKeyboardQClient.DataContracts;

    public class Program
    {
        static void Main(string[] args)
        {
            var sig = new Signal()
            {
                Name = "Serialized Signal",
                Pid = "DK5QPID",
                ZoneId = "2,2",
                Color = "#00FF00",
                Effect = "BLINK"
            };

            // Local Client:
            var localClient = new LocalQClient();
            localClient.CreateSignalAsync(sig);

            // Cloud Client:
            var cloudClient = new CloudQClient("CLIENTID", "SECRET");
            cloudClient.CreateSignalAsync(sig);

            
            Console.ReadKey();
        }
    }
}
