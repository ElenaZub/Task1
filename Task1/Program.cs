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
            UnpackArray();
            Console.ReadKey();
        }

        //
        //Task1
        //
        public static void UnpackArray()
        {
            Console.WriteLine("Enter amount of element in array:");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter element( separated with space): ");
            string str = Console.ReadLine();

            string[] arrayStr = str.Split(' ');
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(arrayStr[i]);
                if (array[0] == 0)
                {
                    for (int j = 1; j <= array[i]; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("0");
                        }
                        else 
                        {
                           Console.Write("1");                       
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < array[i]; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("0");
                        }
                        else 
                        {
                            Console.Write("1");
                        }
                    }
                }
            }
        }
    }
}
