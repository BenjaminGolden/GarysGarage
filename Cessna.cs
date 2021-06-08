using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 100;

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