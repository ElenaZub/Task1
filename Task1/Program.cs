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
            ConverMessage(EnterMessage());

            Console.ReadKey();
        }

        public static void ConverMessage(string msg)
        {
            string[] arrayStr = msg.Split(' ');
            string arrayWithUpp = String.Empty;
            for (int i = 0; i < arrayStr.Length; i++)
            {
                arrayWithUpp += arrayStr[i].Substring(0, 1).ToUpper() + arrayStr[i].Substring(1) + " ";
            }

            Console.WriteLine(arrayWithUpp);
        }

        public static string EnterMessage()
        {
            Console.WriteLine("Enter message:");
            return Console.ReadLine();
        }
    }
}
