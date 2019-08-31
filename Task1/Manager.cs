using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Manager
    {
        private readonly Fridge fridge;

        public Manager(Fridge fridge)
        {
            this.fridge = fridge;
            this.fridge.FridgeStateChange += this.PrintChange;
        }

        public void Execute()
        {
            while (true)
            {
                Console.WriteLine("Choose the action:");
                Console.WriteLine("1. Close of freezer door.");
                Console.WriteLine("2. Open of freezer door.");
                Console.WriteLine("3. Close of main door.");
                Console.WriteLine("4. Open of main door state.");
                Console.WriteLine("5. Turn on the fridge power.");
                Console.WriteLine("6. Turn of the fridge power.");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        fridge.CloseFreezerDoor();
                        break;
                    case 2:
                        fridge.OpenFreezerDoor();
                        break;
                    case 3:
                        fridge.CloseMainDoor();
                        break;
                    case 4:
                        fridge.OpenMainDoor();
                        break;
                    case 5:
                        fridge.TurtOnFridge();
                        break;
                    case 6:
                        fridge.TurtOffFridge();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
        }

        public void PrintChange(object sender, FridgeEventArgs e)
        {
            Console.WriteLine(new String('-', 60));
            Console.WriteLine($"Freezer door is {e.FreezerDoor}, main door is {e.MainDoor}, fridge power is {e.FridgePower}.");
            Console.WriteLine(new String('-', 60));
        }
    }
}