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
            Worker firstWorker = new Worker("Ivan", 25, 1000);
            Worker secondWorker = new Worker("Vasya", -3, 2000);

            Console.WriteLine($"Sum of salary {firstWorker.Salary + secondWorker.Salary}");
            Console.WriteLine($"Sum of ages {firstWorker.Age + secondWorker.Age}");

            Console.ReadKey();
        }
    }
}
