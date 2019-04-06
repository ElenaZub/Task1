﻿using System;
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
            Calculation();
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
            int amountOfRank=Convert.ToString(number).Length;
            if (number % 2 == 1 && amountOfRank==3)
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
            z =--x - y * 5;
            y /= x + 5 % z;
            z = x++ + y * 5;
            x = y - x++ * z;
            Console.WriteLine($"x ={x}, y={y}, z={z}");
        }
    }
}
