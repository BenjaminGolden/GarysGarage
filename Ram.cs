using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Dodge Ram drives past. VRooommm!");
        }

        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}