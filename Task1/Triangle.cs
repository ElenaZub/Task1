using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Triangle
    {
        public static void SumOfOddNumbers()
        {
            int rows = EnterRows();

            Console.WriteLine($"Sum of odd numbers in {rows} rows of a triangle is {Sum(rows)}.");
        }

        public static int EnterRows()
        {
            int rows = 0;

            while (true)
            {
                Console.Write("Enter the number of rows of the triangle:");

                if (Int32.TryParse(Console.ReadLine(), out rows) && (rows > 0))
                    break;
                else
                    Console.WriteLine("Invalid value. Try again:");
            }

            return rows;
        }

        public static int Sum(int rows)
        {
            return rows * rows * rows;
        }
    }
}
