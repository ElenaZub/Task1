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
            //HourPassed(7400);
            //PlaceOfVariable(1, 4, 3);
            //IsOdd(135);
            //Calculation();
            //Calculator();
            //RangeOfNumber();
            Translator();
            Console.ReadKey();
        }

        public static void HourPassed(int seconds)
        {
            int hours = seconds / 3600;
            Console.WriteLine($" in {seconds} seconds is {hours} hours");
        }

        public static void PlaceOfVariable(int a, int b, int c)
        {
            if (a < b && b < c)
            {
                Console.WriteLine("B is between A and C");
            }
            else
                Console.WriteLine("B is not between A and C");
        }

        public static void IsOdd(int number)
        {
            int amountOfRank = Convert.ToString(number).Length;
            if (number % 2 == 1 && amountOfRank == 3)
            {
                Console.WriteLine($"{number} is odd and has {amountOfRank} rank");
            }
            else
                Console.WriteLine(" Statement is false");
        }

        public static void Calculation()
        {
            int x = 10;
            int y = 12;
            int z = 3;
            x += y - x++ * z;
            z = --x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;
            Console.WriteLine($"x ={x}, y={y}, z={z}");
        }

        public static void Calculator()
        {
            int operand1 = 5;
            int operand2 = 2;
            Console.WriteLine("Enter math operation:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine(" Division by zero is impossible");
                    }
                    else
                        Console.WriteLine($"{operand1} / {operand2} = {((double)operand1 / operand2)}");
                    break;
                default:
                    Console.WriteLine("Operation is undeclared");
                    break;
            }
        }

        public static void RangeOfNumber()
        {
            Console.WriteLine(" Enter number from 0 to 100");
            int number = Convert.ToInt32(Console.ReadLine());
            if (0 <= number && number <= 14)
            {
                Console.WriteLine("Number is in range from 0 to 14");
            }
            if (15 <= number && number <= 35 )
            {
                Console.WriteLine("Number is in range from 15 to 35");
            }
            if (36 <= number && number <= 50)
            {
                Console.WriteLine("Number is in range from 35 to 50");
            }
            if (50<= number && number <= 100)
            {
                Console.WriteLine("Number is in range from 51 to 100");
            } 
            if (0 > number || number > 100)
                Console.WriteLine("Number is not in range from 0 to 100");
        }


        public static void Translator()
        {
            Console.WriteLine("Enter the word (мороз, солнце, дождь, тучи, ветер, гроза, туман, снег, жара, облака ):");
            string word = Console.ReadLine();
            switch (word)
            {
                case "мороз":
                    Console.WriteLine("frost");
                    break;
                case "солнце":
                    Console.WriteLine("sun");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "тучи":
                    Console.WriteLine("clouds");
                    break;
                case "ветер":
                    Console.WriteLine("wind");
                    break;
                case "гроза":
                    Console.WriteLine("thunderstorm");
                    break;
                case "туман":
                    Console.WriteLine("fog");
                    break;
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "жара":
                    Console.WriteLine("heat");
                    break;
                case "облака":
                    Console.WriteLine("clouds");
                    break;
                default:
                    Console.WriteLine("Undefined word");
                    break;
            }
        }
    }
}
