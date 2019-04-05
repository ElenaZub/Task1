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
            Task1();
            Task2();
            Task3();
            Task4();
            Task5(3, 1);
            Task6(15);
            Task7();
            Task8();

        }

        static public void Task1()
        {
            int x1 = 6;
            Console.WriteLine(x1);
        }

        static public void Task2()
        {
            string str1;
            Console.WriteLine("Ваше имя?");
            str1 = Console.ReadLine();
            string str2 = "Привет " + str1;
            Console.WriteLine(str2);
        }

        static public void Task3()
        {
            var v1 = 'v';
            v1 = 'k';
            Console.WriteLine(v1);
        }

        static public void Task4()
        {
            Console.WriteLine("Введите длину стороны квадрата:");
            int x = Convert.ToInt32(Console.ReadLine());
            int P;
            P = 4 * x;
            Console.WriteLine("P = {0}", P);
        }

        static public void Task5(decimal R1, decimal R2)
        {
            decimal S1;
            decimal S2;
            decimal S3;

            const decimal PI = 3.14m;

            S1 = PI * R1 * R1;
            S2 = PI * R2 * R2;
            S3 = S1 - S2;

            Console.WriteLine("S1 = {0}, S2 = {1}, S3 = {2}", S1, S2, S3);

        }

        static public void Task6(int number)
        {
            int numeral1;
            int numeral2;
            numeral1 = number / 10;
            numeral2 = number % 10;
            Console.WriteLine("Десятки {0}", numeral1);
            Console.WriteLine("Единицы {0}", numeral2);
        }

        public static void Task7()
        {
            int num1 = 5;
            int num2 = 199999;
            long sum = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }

        public static void Task8()
        {
            long a = 15;
            long b = 456768586;
            byte c = (byte)(a + b);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
        }

        public static void Task9_1(int a, int b)
        {
            int c;

            Console.WriteLine("До: а = {0}, b = {1} ", a, b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("После: а = {0}, b = {1} ", a, b);

        }

        public static void Task9_2(int a, int b)
        {
            Console.WriteLine("До: а = {0}, b = {1} ", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("После: а = {0}, b = {1} ", a, b);
        }




    }
}
