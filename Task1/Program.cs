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







    }
}
