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

            Console.Write("Enter radius: ");
            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);

            Console.WriteLine($"The square of the sircle is {Program.PerformCalculation(radius)}");
            Console.ReadKey();
           
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal PI = 3.14m;

            decimal square = PI * r*r;

            return square;
        }
    }
}
