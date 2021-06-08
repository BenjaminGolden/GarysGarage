using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public string Model{ get; set; }
        public string Sound { get; set; }

        public string Direction { get; set; }

        //Methods:
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} {Model} goes past. {Sound}!");
        }

        public virtual void Turn(string Direction)
        {
            Console.WriteLine($"The {Model} turns to the {Direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"the {Model} gently rolls to a stop.");
        }
    }
}