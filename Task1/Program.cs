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
            Fridge fridge = new Fridge();

            Manager manager = new Manager(fridge);
            manager.Execute();

            Console.ReadKey();
        }
    }
}