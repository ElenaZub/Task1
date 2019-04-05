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







    }
}
