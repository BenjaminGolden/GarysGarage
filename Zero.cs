using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 100;

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