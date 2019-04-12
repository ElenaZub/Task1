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
            Factorial(5);
            Console.ReadKey();
        }
   
        public static void Factorial(int number)
        {
            int factorial = 1;
            while (number > 0)
            {
                factorial = factorial * number;
                number--;
            }
            Console.WriteLine($"Factorial = {factorial}");
        }

    }
}
