using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Stop()
        {
            // base.Stop();
            {
                Console.WriteLine($"The {Model} never stopped!");
            }
        }
    }
}