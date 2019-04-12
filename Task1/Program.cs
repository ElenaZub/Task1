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
            //Factorial(5);
            SumBetweenNumbers(3, 6);
            OddValuesBetweenNumbers(5, 12);
            Console.ReadKey();
        }
   
        public static void Factorial(int number)
        {
            int factorial = 1;
            while (number > 0)
            {
                factorial = factorial * number;
                number--;
            }
            Console.WriteLine($"Factorial = {factorial}");
        }

        public static void SumBetweenNumbers(int number1, int number2)
        {
            int sum = 0;
            for (int i = number1+1; i < number2; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of numbers between {number1} and {number2} = {sum}");
        }

        public static void OddValuesBetweenNumbers(int number1, int number2)
        {
            String odd = "";
            for (int i = number1 + 1; i < number2; i++)
            {
                if (i % 2 == 1)
                {
                    odd = odd + " " + i;
                }
            }
            Console.WriteLine($"Odd values between {number1} and {number2} is"+ odd);
        }
    }
}
