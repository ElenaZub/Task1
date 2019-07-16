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

            int[] array = CreateRandomArray(n);
            PrintArray(array);

            //Min(array);
            //Max(array);
            //Mean(array);
            //Odd(array);
            //IndexesOfElementsInRange(array);
            //ElementsMoreThanMean(array, Mean(array));
            //int[] reverseArray = MyReverse(array);
            //PrintArray(reverseArray);

            Console.WriteLine("Enter index:");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter count:");
            int count = int.Parse(Console.ReadLine());

            PrintArray(SubArray(array, index, count));
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

        public static double Mean(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double mean = (double)sum / array.Length;
            return mean;
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
                if (array[i] > min && array[i] < max)
                    Console.WriteLine(i);
            }
        }

        public static void ElementsMoreThanMean(int[] array, double mean)
        {
            Console.WriteLine($"Elements that are more then mean value = {mean}:");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mean)
                    Console.WriteLine(array[i]);        
            }
        }

        public static int[] MyReverse(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            int tmp;

            for (int i = 0; i < reverseArray.Length; i++)
            {
                for (int j = array.Length - 1; j >= 0 ; j--)
                {
                    tmp = array[j];
                    reverseArray[i] = tmp;
                    i++;
                }
            }

            return reverseArray;
        }

        public static int[] SubArray(int[] array, int index, int count) 
        {
            int[] subArray = new int[count];
            int tmp = index;

            for (int i = 0; i < subArray.Length; i++)
            {
                if (tmp < array.Length)
                {
                    subArray[i] = array[tmp];
                    tmp++;
                }
                else
                    subArray[i] = 1;
            }
            return subArray;
        }
    }
}
