using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Manager
    {
        private Monitor monitor = new Monitor();

        private TV tv = new TV();

        public void Manage()
        {
            while (true)
            { 
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Turn on monitor.");
                Console.WriteLine("2. Turn off monitor.");
                Console.WriteLine("3. Turn on tv.");
                Console.WriteLine("4. Turn off tv.");

                int option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        tv.TurnOn();
                        Console.WriteLine(tv);
                        break;
                    case 2:
                        tv.TurnOff();
                        Console.WriteLine(tv);
                        break;
                    case 3:
                        monitor.TurnOn();
                        Console.WriteLine(monitor);
                        break;
                    case 4:
                        monitor.TurnOff();
                        Console.WriteLine(monitor);
                        break;
                    default:
                        Console.WriteLine("Invalid value. Try again.");
                        break;
                }
            }
        }
    }
}
