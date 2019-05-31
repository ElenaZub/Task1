using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] veh = {
                new Car(4, EngineType.Electro, Gearbox.Auto, 4, ConsoleColor.Blue, -20, 4),
                new Bicycle(BicycleType.RoadBike, BreakType.FootBrakes, 2, ConsoleColor.Red, 100, 2),
                new Moto(MotoType.Chopper, 2, ConsoleColor.Green, 150, 2),
                new Car(4, EngineType.Disel, Gearbox.Manual, 5, ConsoleColor.Blue, 300, 2),
                new Bicycle(BicycleType.BMX, BreakType.HandBrakes, 2, ConsoleColor.Red, 130, 2),
                new Moto(MotoType.Cruiser, 2, ConsoleColor.Green, 120, 2)
            };

            foreach (var item in veh)
            {

                item.PrintTable();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('-',120));

            foreach (var item in veh)
            {
                item.Move(300);
            }

            Console.ReadKey();
        }
    }
}
