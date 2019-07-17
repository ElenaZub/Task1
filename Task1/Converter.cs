using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Converter
    {
        public static void Convert()
        {
            string[] currencies = { "RUB", "USD", "EUR", "UAH" };
            decimal[] courses = { 0.4m, 26.8m, 30, 1 };

            for (int i = 0; i < currencies.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {currencies[i]}");
            }

            Console.Write("Enter number of currency before converting(1 - 4): ");
            int currencyBefore = ChooseCurrency();

            Console.Write("Enter the amount of money: ");
            decimal moneyAmount = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter number of currency for converting(1 - 4): ");
            int currencyAfter = ChooseCurrency();

            decimal result = moneyAmount * courses[currencyBefore] / courses[currencyAfter];

            Console.WriteLine($"Convert: {moneyAmount} {currencies[currencyBefore]} - > {result} {currencies[currencyAfter]} ");
        }

        public static int ChooseCurrency()
        {
            int number = 0;
            bool isValid = false;

            while (isValid == false)
            {
                Int32.TryParse(Console.ReadLine(), out number);
                if (number <= 0 || number > 4)
                {
                    Console.WriteLine("You entered invalid value. Try again: ");
                }
                else
                {
                    number = number - 1;
                    isValid = true;
                }
            }

            return number;
        }
    }
}
