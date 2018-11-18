using System;

namespace PowerZone
{
    class Athlete
    {
        public int thresholdPower { get; }

        public Athlete(int thresholdPower)
        {
            this.thresholdPower = thresholdPower;
        }

        // @see  https://www.trainingpeaks.com/blog/power-training-levels/  zone
        //     upper and lower bounds (accessed 2018-11-18)
        public int Zone(int currentPower)
        {
            int zone;

            // use Math.Ceiling() to create contiguous zones
            if (currentPower <= Math.Ceiling(0.55 * thresholdPower))
            {
                zone = 1;
            }
            else if (
                currentPower > Math.Ceiling(0.55 * thresholdPower)
                && currentPower <= Math.Ceiling(0.75 * thresholdPower)
            ) {
                zone = 2;
            }
            else if (
                currentPower > Math.Ceiling(0.75 * thresholdPower)
                && currentPower <= Math.Ceiling(0.90 * thresholdPower)
            ) {
                zone = 3;
            }
            else if (
                currentPower > Math.Ceiling(0.90 * thresholdPower)
                && currentPower <= Math.Ceiling(1.05 * thresholdPower)
            ) {
                zone = 4;
            }
            else if (
                currentPower > Math.Ceiling(1.05 * thresholdPower)
                && currentPower <= Math.Ceiling(1.20 * thresholdPower)
            ) {
                zone = 5;
            }
            else
            {
                zone = 6;
            }

            return zone;
        }
    }
}
