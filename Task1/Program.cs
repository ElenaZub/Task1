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
            //PowOfNumber(5, 2);
            //PropertyOfNumber();
            //Multiplication(-5, -3);
            //DeletDigit();
            MaxDigit(-16759);
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

        public static void PropertyOfNumber()
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Whether the entered number is positive or negative: ");
            Console.WriteLine("2. Is it simple");
            Console.WriteLine("3. Is it divided into 2, 5, 3, 6, 9 without a residue");
            Console.WriteLine("Choose the action:");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    if (number < 0)
                    {
                        Console.WriteLine(" The number is negative.");
                    }
                    else
                        Console.WriteLine(" The number is positive.");
                    break;
                case 2:
                    int count = 1;
                    for (int i = 1; i <= 5; i++)
                    {
                        if (number % i == 0)
                            count++;
                    }
                    if (count > 2)
                    {
                        Console.WriteLine(" The number is not simple.");
                    }
                    else
                        Console.WriteLine(" The number is simple.");

                    break;
                case 3:
                    string deviding = "";
                    if (number % 2 == 0)
                        deviding = deviding + " 2 ";
                    if (number % 5 == 0)
                        deviding = deviding + " 5 ";
                    if (number % 3 == 0)
                        deviding = deviding + " 3 ";
                    if (number % 6 == 0)
                        deviding = deviding + " 6 ";
                    if (number % 9 == 0)
                        deviding = deviding + " 9 ";
                    //придумать что-то с запятыми!
                    Console.WriteLine(" The number is divided without remainder by " + deviding);
                    break;
                default:
                    Console.WriteLine(" Wrong number of menu");
                    break;
            }
        }

        public static void Multiplication(int number1, int number2)
        {
            int multiplication = 0;
            if (number1 > 0 && number2 > 0)
            {
                for (int i = 0; i < number2; i++)
                {
                    multiplication = multiplication + number1;
                }
            }
            else if (number1 < 0 && number2 > 0)
            {
                for (int i = 0; i < number2; i++)
                {
                    multiplication = multiplication + number1;
                }
            }
            else if (number1 < 0 && number2 < 0)
            {
                for (int i = 0; i < (-number2); i++)
                {
                    multiplication = multiplication + (-number1);
                }
            }
            else if (number1 > 0 && number2 < 0)
            {
                for (int i = 0; i < (-number2); i++)
                {
                    multiplication = multiplication + (-number1);
                }
            }
            Console.WriteLine(multiplication);
        }

        public static void DeletDigit()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the digit:");
            int digit = Convert.ToInt32(Console.ReadLine());
            int newNumber = 0;
            int rank = 1;
            while (number > 0)
            {
                int rest = number % 10;
                number = number / 10;
                if (rest == digit)
                    continue;             
                newNumber = newNumber + rest * rank;
                rank = rank * 10;
            }
            Console.WriteLine(newNumber);       
        }

        public static void MaxDigit(int number)
        {
            if (number < 0)
            {
                number = -number;
            }
            int max = number % 10;
            int rest = 0;
            while (number > 0)
            {
                rest = number % 10;
                if (max < rest)
                {
                    max = rest;
                }
                number = number / 10;
            }
            Console.WriteLine(max);
        }
    }
}


