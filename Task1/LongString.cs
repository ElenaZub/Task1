using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class LongString
    {
        public static void Execute()
        {
            Console.WriteLine("Enter first string:");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter first string:");
            string secondString = Console.ReadLine();

            Console.WriteLine(Longest(firstString, secondString));
        }

        public static string Longest(string a, string b)
        {
            string newString = string.Empty;
            string concatString = a + b;

            for (int i = 0; i < concatString.Length; i++)
            {
                bool isInString = false;

                for (int j = 0; j < newString.Length; j++)
                {
                    if (concatString[i] == newString[j])
                    {
                        isInString = true;
                        break;
                    }
                }

                if (isInString == false)
                {
                    newString += concatString[i];
                    isInString = false;
                }
            }

            var charArray = newString.ToArray();
            Array.Sort(charArray);

            newString = string.Join("", charArray);

            return newString;
        }
    }
}
