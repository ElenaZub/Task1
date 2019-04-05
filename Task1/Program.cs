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
            RightName();
            PrintNumber();
            PrintString();
            Console.ReadKey();
        }

        public static void RightName()
        {
            string uberflu;
            string _identifier;
            string \u006fidentifier;
            string myVar;
            string myVariable;
        }

        public static void PrintNumber()
        {
            const decimal PI = 3.141592653m;
            const decimal Eyler = 2.71828182459054m;
            Console.WriteLine($"PI: {PI}, Eyler: {Eyler}");
        }

        public static void PrintString()
        {
            String str1="\nмоя строка 1";
            String str2= "\nмоя строка 2";
            String str3= "\nмоя строка 3";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
