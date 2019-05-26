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
            //DeleteDublicate(EnterString());
            NumberOfSymbol(EnterString());

            Console.ReadKey();
        }

        public static string EnterString()
        {
            Console.WriteLine("Enter string:");
            return Console.ReadLine();
        }

        public static void DeleteDublicate(string str)
        {
            string res = string.Empty;
            bool isDublicate;

            for (int i = 0; i < str.Length; i++)
            {
                isDublicate = false;
                for (int j = 0; j < res.Length; j++)
                {
                    if (str[i] == res[j])
                    {
                        isDublicate = true;
                    }
                }
                if(isDublicate == false)
                {
                    res += str[i];
                }
            }

            Console.WriteLine(res);
        }

        public static void NumberOfSymbol(string str)
        {
            Console.WriteLine("Enter symbol to count numbers of dublicate:");
            char symbol = char.Parse(Console.ReadLine());
            int count = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (symbol == str[i])
                {
                    count++;
                }
            }

            Console.WriteLine($"{symbol} dublicated {count} times");
        }   
    }
}
