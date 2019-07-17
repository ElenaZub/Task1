using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ATM
    {
        public static void ValidatePin()
        {
            string password = EnterPassword();

            Console.WriteLine($"{password} => {isPinValid(password)} ");
        }

        public static bool isPinValid(string password)
        {
            if ((password.Length == 4 || password.Length == 6)
                && Int32.TryParse(password, out var tmp))
                return true;
            else
                return false;
        }

        public static string EnterPassword()
        {
            Console.WriteLine("Enter password for checking:");

            return Console.ReadLine();
        }
    }
}
