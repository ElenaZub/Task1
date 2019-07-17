using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Bank
    {
        public static void BankAction()
        {
            decimal minMonthPayment = 100;
            decimal debt = 700;

            while (debt > 0)
            {
                PaymentInfo(ref debt, Payment(minMonthPayment));
            }
        }

        public static void PaymentInfo(ref decimal debt, decimal payment)
        {
            debt -= payment;

            if (debt > 0)
            {
                Console.WriteLine($"Current debt is {debt}");
            }
            else if (debt == 0)
            {
                Console.WriteLine("You dont have debt");
            }
            else if (debt < 0)
            {
                Console.WriteLine($"Current overpayment is {Math.Abs(debt)}");
            }
        }

        public static decimal Payment(decimal minMonthPayment)
        {
            decimal monthPayment;

            while (true)
            {
                Console.WriteLine("Enter amount of money:");

                if (Decimal.TryParse(Console.ReadLine(), out monthPayment) && monthPayment >= minMonthPayment)
                    return monthPayment;
                else
                {
                    Console.WriteLine("Payment amount less than minimum payment");
                }
            }
        }
    }
}
