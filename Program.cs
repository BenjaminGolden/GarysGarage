using System;

namespace Garage
{
    class Program 
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "black",
                MaximumOccupancy = 5,
                Model = "RoadBike",
                Sound = "hmmm"
                
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Red",
                MaximumOccupancy = 5,
                Model = "Model S",
                Sound = "sssssssss"
                
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 5,
                Model = "MX410",
                Sound = "zoom"
               
            };
            Ram hemi = new Ram()
            {
                MainColor = "blue",
                MaximumOccupancy = 5,
                Model = "charger",
                Sound = "vroomm"
               
            };
            

            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("Right");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("Straight");
            mx410.Stop();
            Console.WriteLine();

            hemi.Drive();
            hemi.Turn("Left");
            hemi.Stop();
            Console.WriteLine();
        }
    }
}
