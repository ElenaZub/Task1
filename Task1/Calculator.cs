using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Calculator
    {
        public static int Add(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }

        public static int Sub(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }

        public static int Mul(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }

        public static double Div(int firstValue, int secondValue)
        {
            if (secondValue != 0)
            {
                return (double)firstValue / secondValue;
            }
            else
            {
                Console.WriteLine("Can be devided with 0");
                return 0;
            }     
        }

        public static int EnterNumber()
        {
            int number;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                {
                    Console.WriteLine("You entered invalid value! Enter again:");
                }
            }

            return number;
        }

        public static char OperationEnter()
        {
            var operations = new char[]{'*', '+', '-', '/'};
            char operation;
            bool isOperation = false;

            while (true)
            {
                operation = char.Parse(Console.ReadLine());
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operation == operations[i])
                    {
                        isOperation = true;
                        break;
                    }
                }
                if (isOperation)
                {                   
                    break;
                } 
                else
                {
                    Console.WriteLine("You entered invalid value! Enter again:");
                }
            }

            return operation;
        }

        public static void Calculate()
        {
            while (true)
            {
                Console.WriteLine("Enter first value:");
                int firstValue = EnterNumber();

                Console.WriteLine("Enter second value:");
                int secondValue = EnterNumber();

                Console.WriteLine("Enter operation(*, +, -, /):");
                char operation = OperationEnter();

                switch (operation)
                {
                    case '+':
                        Console.WriteLine($"{firstValue} + {secondValue} = {Add(firstValue, secondValue)}");
                        break;
                    case '-':
                        Console.WriteLine($"{firstValue} - {secondValue} = {Sub(firstValue, secondValue)}");
                        break;
                    case '*':
                        Console.WriteLine($"{firstValue} * {secondValue} = {Mul(firstValue, secondValue)}");
                        break;
                    case '/':
                        Console.WriteLine($"{firstValue} / {secondValue} = {Div(firstValue, secondValue)}");
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
            }
        }
    }
}
