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

            //int[] array = CreateRandomArray(n);
            //PrintArray(array);

            int[,] array2D = Create2DRandomArray(n + 1);
            Print2DArray(array2D);

            //Min(array);
            //Max(array);
            //Mean(array);
            //Odd(array);
            //IndexesOfElementsInRange(array);
            //ElementsMoreThanMean(array, Mean(array));
            //int[] reverseArray = MyReverse(array);
            //PrintArray(reverseArray);

            //Console.WriteLine("Enter index:");
            //int index = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter count:");
            //int count = int.Parse(Console.ReadLine());

            //PrintArray(SubArray(array, index, count));

            //Console.WriteLine("Enter value:");
            //int value = int.Parse(Console.ReadLine());

            //PrintArray(ExtendArray(array, value));

            //Console.WriteLine("Enter value:");
            //int value = int.Parse(Console.ReadLine());
            //int count = RepeatCounter(array2D, value);
            //if (count == 0)
            //{
            //    Console.WriteLine($"{value} doesn't repeat");
            //}
            //else if(count == 1)
            //{
            //    Console.WriteLine($"{value} repeats {count} time");
            //}
            //else
            //    Console.WriteLine($"{value} repeats {count} time");

            Console.WriteLine("Swaped 2D array:");
            Print2DArray(Swap(array2D, 2, 4));
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

        public static int[,] Create2DRandomArray(int length)
        {
            Random rand = new Random();
            int[,] array = new int[length, length];

            int uBound0 = array.GetUpperBound(0);
            int uBound1 = array.GetUpperBound(1);

            for (int i = 0; i < uBound0; i++)
            {
                for (int j = 0; j < uBound1; j++)
                { 

                    array[i, j] = rand.Next(1, 100);
                }
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

        public static void Print2DArray(int[,] array)
        {
            int uBound0 = array.GetUpperBound(0);
            int uBound1 = array.GetUpperBound(1);

            for (int i = 0; i < uBound0; i++)
            {
                for (int j = 0; j < uBound1; j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }
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

        public static int[] ExtendArray(int[] array, int value)
        {
            int[] extendedArray = new int[array.Length + 1];
            int tmp;

            for (int i = 0; i < extendedArray.Length; i++)
            {
                if (i < array.Length)
                {
                    tmp = array[i];
                    extendedArray[i] = tmp;
                }
                else
                    extendedArray[i] = value;
            }

            return extendedArray;
        }

        public static int RepeatCounter(int[,] array, int value)
        {
            int count = 0;
            int uBound0 = array.GetUpperBound(0);
            int uBound1 = array.GetUpperBound(1);

            for (int i = 0; i < uBound0; i++)
            {
                for (int j = 0; j < uBound1; j++)
                {
                    if (array[i, j] == value)
                        count++;
                }
            }

            return count;
        }

        public static int[,] Swap(int[,] array2D, int firstRow, int secondRow)
        {
            int uBound0 = array2D.GetUpperBound(0);
            int uBound1 = array2D.GetUpperBound(1);
            int tmp;

            for (int i = 0; i < uBound0; i++)
            {
                for (int j = 0; j < uBound1; j++)
                {
                    if (i == firstRow - 1)
                    {
                        tmp = array2D[i, j];
                        array2D[i, j] = array2D[secondRow - 1, j];
                        array2D[secondRow - 1, j] = tmp;
                    }
                }
            }

            return array2D;
        }


    }
}
