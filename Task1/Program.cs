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
    }
}
