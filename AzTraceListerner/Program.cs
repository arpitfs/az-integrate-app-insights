using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TelemetryConfiguration.Active.InstrumentationKey = "INSTRUMENTATION_KEY";
            var client = new TelemetryClient();
            client.TrackTrace("Demo application starting up.");
            Debug.WriteLine("Other log");
            client.Flush();
        }
    }
}
