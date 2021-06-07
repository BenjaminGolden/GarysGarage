using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} {Model} flys past. {Sound}!");
        }
        public override void Turn(string Direction)
        {
            // base.Turn(Direction);
            {
                Console.WriteLine($"the {Model} keeps going {Direction}.");
            }
        }
    }
}