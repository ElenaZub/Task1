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
            short num1 = 10;
            int num2 = 15;

            Console.WriteLine($"{num1}+{num2}={Program.Sum(num1,num2)}");
            Console.ReadLine();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
