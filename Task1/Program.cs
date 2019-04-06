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
             HourPassed(7400);
             Console.ReadKey();
        }

        public static void HourPassed(int Seconds)
        {
            int Hours = Seconds / 3600;
            Console.WriteLine($" in {Seconds} seconds is {Hours} hours");             
        }
    }
}
