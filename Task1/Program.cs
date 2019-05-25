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
            //UnpackArray();
            CalculateTotalPrice();

            Console.ReadKey();
        }

        public static void UnpackArray()
        {
            Console.WriteLine("Enter amount of element in array:");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter element (separated with space): ");
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

        public static void CalculateTotalPrice()
        {
            string[] product = { "Pears", "Apples", "Cucumbers", "Tomatos", "Dill", "Parsley", "Chiсken", "Cheese", "Butter", "Milk" };
            decimal[] price = { 40.50M, 31.20M, 21.80M, 35.00M, 150.00M, 145.00M, 200.00M, 400.00M, 81.40M, 53.35M };

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {product[i]} - {price[i]} uah");
            }

            Console.WriteLine("What you want to take? (Enter number of product or 0 to end calculation)");

            decimal sum = 0;

            while (true)
            {
                Console.WriteLine("Product:");
                int numberOfProduct = Int32.Parse(Console.ReadLine());
                if (numberOfProduct == 0)
                    break;

                Console.WriteLine("Amount:");
                decimal amountOfProduct = decimal.Parse(Console.ReadLine());

                sum += price[numberOfProduct - 1] * amountOfProduct;
            }

            Console.WriteLine($"Amount to pay is {sum} uah");
        }
    }
}
