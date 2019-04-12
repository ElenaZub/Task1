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
            //SumBetweenNumbers(3, 6);
            //OddValuesBetweenNumbers(5, 12);
            //CounOfEvenInNumber(34566510);
            //MeanOfNumbers();
            //DaysOfRunning();
            //Square(30);
            //ReverseOfNumber();
            PowOfNumber(5, 2);
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

        public static void CounOfEvenInNumber(int a)
        {
            int b = a;
            int count = 0;
            while (a > 0)
            {
                if ((a % 10) % 2 == 0)
                {
                    count++;
                }
                a = a / 10;
            }
            Console.WriteLine($" The number of even digits in the number {b} is {count}");
        }

        public static void MeanOfNumbers()
        {
            Console.WriteLine("Enter two numbers A and B( A<=B)");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = number1; i <= number2; i++)
            {
                sum += i;
                count++;
            }
            double average = (double)sum / count;
            Console.WriteLine($"Average of numbers between {number1} and {number2} ( inclusive) is {average}");
        }

        public static void DaysOfRunning()
        {
            double distance = 10;
            double sum = 10;
            int days = 1;
            while (sum <= 100)
            {
                distance = distance * 1.1;
                sum = sum + distance;
                days++;
            }
            Console.WriteLine($"Skier ran {sum} for {days} days");
        }

        public static void Square(int N)
        {
            Console.WriteLine($"Squares of numbers less than {N} is: ");
            int i = 1;
            while (i*i<N)
            {
                Console.Write(i*i +" ");
                i++;
            }
        }

        public static void ReverseOfNumber()
        {
            int number = 13456;
            int reverseNumber = 0;
            int remainder = 0;
            while (number > 0)
            {
                remainder = number % 10;
                reverseNumber = reverseNumber * 10;
                reverseNumber = reverseNumber + remainder;
                number = number /10;
            }
            Console.WriteLine(reverseNumber);
        }

        public static void PowOfNumber(int number, int n)
        {
            int count = 1;
            int pow = number;
            while (count < n)
            {
                pow = pow *number ;
                count++;
            }
            Console.WriteLine($"{number}^{n} = {pow}");
        }
    }
}
