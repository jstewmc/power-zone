using System;

namespace PowerZone
{
    class Program
    {
        static void Main(string[] args)
        {
            int thresholdPower, currentPower;

            Console.WriteLine("Enter your threshold power:");
            Int32.TryParse(Console.ReadLine(), out thresholdPower);

            var athlete = new Athlete(thresholdPower);

            Console.WriteLine("Enter your current power:");
            Int32.TryParse(Console.ReadLine(), out currentPower);

            Console.WriteLine($"You're in power zone {athlete.Zone(currentPower)}!");
        }
    }
}
