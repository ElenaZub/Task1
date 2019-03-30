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
            long num1 = 10;
            short num2 = 15;

            Console.WriteLine($"{num1}+{num2}={Program.Sum((int)num1,num2)}");

            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;

            //
            //приводим два числа типа int к типу short.
            //

            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            //
            //приводим число типа decimal к типу int.
            //

            Console.WriteLine((int)dec);
            Console.ReadKey();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }


    }
}
