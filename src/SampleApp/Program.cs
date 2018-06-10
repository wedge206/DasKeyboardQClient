namespace SampleApp
{
    using System;
    using Wedge.DasKeyboardQClient;
    using Wedge.DasKeyboardQClient.DataContracts;

    public class Program
    {
        static void Main(string[] args)
        {
            var client = new CloudQClient("CLIENTID", "SECRET");

            var sig = new Signal()
            {
                Name = "Serialized Signal",
                Pid = "DK5QPID",
                ZoneId = "2,2",
                Color = "#00FF00",
                Effect = "BLINK"
            };

            client.CreateSignalAsync(sig).Wait();

            Console.ReadKey();
        }
    }
}
