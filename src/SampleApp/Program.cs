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
            //var localClient = new LocalQClient();
            //localClient.CreateSignal();
            var sig = new Signal()
            {
                Name = "Serialized Signal",
                Pid = "DK5QPID",
                ZoneId = "2,2",
                Color = "#00FF00",
                Effect = "BLINK"
            };
            var test = sig.ToJSON();
            //  client.CreateSignalAsync(sig).Wait();
            var result = client.GetColorsAsync().Result;

            Console.WriteLine("Hello World!");
       //     Console.ReadKey();
        }
    }
}
