using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static object Converte { get; private set; }

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

            Console.WriteLine("Enter 3 numbers");

            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();

            int.TryParse(n1, out int number1);
            int.TryParse(n2, out int number2);
            int.TryParse(n3, out int number3);

            decimal average = AverageMean(number1, number2, number3);

            Console.WriteLine($" Среднее значение = {average}");

            Console.ReadKey();


        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static decimal AverageMean(int a,int b, int c)
        {
            return (decimal)(a + b + c)/ 3;
        }


    }
}
