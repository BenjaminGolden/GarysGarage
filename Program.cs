using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}

// namespace Garage
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero()
//             {
//                 MainColor = "black",
//                 MaximumOccupancy = 5,
//                 Model = "RoadBike",
//                 Sound = "hmmm"
                
//             };
//             Tesla modelS = new Tesla()
//             {
//                 MainColor = "Red",
//                 MaximumOccupancy = 5,
//                 Model = "Model S",
//                 Sound = "sssssssss"
                
//             };
//             Cessna mx410 = new Cessna()
//             {
//                 MainColor = "White",
//                 MaximumOccupancy = 5,
//                 Model = "MX410",
//                 Sound = "zoom"
               
//             };
//             Ram hemi = new Ram()
//             {
//                 MainColor = "blue",
//                 MaximumOccupancy = 5,
//                 Model = "charger",
//                 Sound = "vroomm"
               
//             };
            

//             fxs.Drive();
//             fxs.Turn("Left");
//             fxs.Stop();
//             Console.WriteLine();

//             modelS.Drive();
//             modelS.Turn("Right");
//             modelS.Stop();
//             Console.WriteLine();

//             mx410.Drive();
//             mx410.Turn("Straight");
//             mx410.Stop();
//             Console.WriteLine();

//             hemi.Drive();
//             hemi.Turn("Left");
//             hemi.Stop();
//             Console.WriteLine();
//         }
//     }
// }
