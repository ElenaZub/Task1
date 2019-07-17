using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CamelCase
    {
        public static void Execute()
        {
            Console.WriteLine("Enter string with '_' or '-':");
            string input = Console.ReadLine();

            Console.WriteLine(ToCamelCase(input));
        }

        public static string ToCamelCase(string initialString)
        {
            bool isDash = false;
            bool isUnderscore = false;

            for (int i = 0; i < initialString.Length; i++)
            {
                if (initialString[i] == '-')
                {
                    isDash = true;
                    break;
                }
                else if (initialString[i] == '_')
                {
                    isUnderscore = true;
                    break;
                }
            }

            string newString = String.Empty;

            if (isDash)
            {
                var dashArray = initialString.Split('-');
                newString += dashArray[0].ToLower();

                for (int i = 1; i < dashArray.Length; i++)
                {
                    newString += dashArray[i][0].ToString().ToUpper() + dashArray[i].Substring(1).ToLower();
                }
            }
            else if (isUnderscore)
            {
                var dashArray = initialString.Split('_');

                for (int i = 0; i < dashArray.Length; i++)
                {
                    newString += dashArray[i][0].ToString().ToUpper() + dashArray[i].Substring(1).ToLower();
                }
            }

            return newString;
        }
    }
}
