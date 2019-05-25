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
            //CalculateTotalPrice();
            //PrintPerfectNumber();
            //EncryptMessage();
            DecryptMessage();

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

        public static void PrintPerfectNumber()
        {
            Console.WriteLine("Perfect numbers in interval from 1 to 1000:");

            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (i == sum)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void EncryptMessage()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            Console.WriteLine("Enter message:");
            string message = Console.ReadLine();

            var encryptMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (message[i] == encryptChars[j])
                    {
                        encryptMessage[i] = cipher[j];
                        break;
                    }
                    else
                        encryptMessage[i] = cipher[10];
                }
            }

            Console.WriteLine("Encrypted message:");
            foreach (var item in encryptMessage)
            {
                Console.Write(item);
            }
        }

        public static void DecryptMessage()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };

            Console.WriteLine("Enter encrypt message:");
            string message = Console.ReadLine();

            var decryptMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (message[i] == cipher[j])
                    {
                        decryptMessage[i] = encryptChars[j];
                        break;
                    }
                }
            }

            Console.WriteLine("Decrypted message:");
            foreach (var item in decryptMessage)
            {
                Console.Write(item);
            }
        }
    }
}
