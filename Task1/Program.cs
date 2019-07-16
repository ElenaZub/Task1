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
            Console.WriteLine("Enter amount of numbers in array:");
            int n = int.Parse(Console.ReadLine());

            int [] array = CreateRandomArray(n);
            PrintArray(array);

            //Min(array);
            //Max(array);
            //Mean(array);
            //Odd(array);
            IndexesOfElementsInRange(array);
        }

        public static int[] CreateRandomArray(int length)
        {
            Random rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }  
            Console.WriteLine();
        }

        public static void Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($"Min value is {min}");
        }

        public static void Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            Console.WriteLine($"Max value is {max}");
        }

        public static void Mean(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }   
            double mean = (double)sum / array.Length;

            Console.WriteLine($"Sum of elements is {sum}");
            Console.WriteLine($"Mean value is {mean}");
        }

        public static void Odd(int[] array)
        {
            Console.WriteLine("Odd elements:");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static void IndexesOfElementsInRange(int[] array)
        {
            Console.WriteLine("Enter min value:");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max value:");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine($"Indexes of elements that are more then {min} and less then {max}:");
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > min && array[i] < max)
                    Console.WriteLine(i);
            }
        }
    }
}
