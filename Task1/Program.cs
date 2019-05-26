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
            //DeleteDublicate(EnterString());
            //NumberOfSymbol(EnterString());
            //InsertString(EnterString(), 7);
            //DeleteSpace(EnterString());
            //PrintFirstLetter(EnterString());
            //PrintReverseOrder(EnterString());
            LengthOfWord(EnterString());

            Console.ReadKey();
        }

        public static string EnterString()
        {
            Console.WriteLine("Enter string:");
            return Console.ReadLine();
        }

        public static void DeleteDublicate(string str)
        {
            string res = string.Empty;
            bool isDublicate;

            for (int i = 0; i < str.Length; i++)
            {
                isDublicate = false;
                for (int j = 0; j < res.Length; j++)
                {
                    if (str[i] == res[j])
                    {
                        isDublicate = true;
                    }
                }
                if(isDublicate == false)
                {
                    res += str[i];
                }
            }

            Console.WriteLine(res);
        }

        public static void NumberOfSymbol(string str)
        {
            Console.WriteLine("Enter symbol to count numbers of dublicate:");
            char symbol = char.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (symbol == str[i])
                {
                    count++;
                }
            }

            Console.WriteLine($"{symbol} dublicated {count} times");
        }

        public static void InsertString(string oldStr,int position)
        {
            Console.WriteLine("Enter string for pasting:");
            string strForInsert = Console.ReadLine();

            string firstPart = oldStr.Substring(0, position-1);
            string secondPart = oldStr.Substring(position - 1, oldStr.Length - position);
            string newStr = firstPart + strForInsert + secondPart;

            Console.WriteLine(newStr);
        }

        public static void DeleteSpace(string str)
        {
            int position1=str.IndexOf('?');
            int position2 = str.IndexOf('?',position1 + 1);
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (i < position1 || i > position2)
                {
                    newStr += str[i];
                }
                else
                {
                    if (str[i] != ' ')
                        newStr += str[i];
                } 
            }

            Console.WriteLine(newStr);
        }

        public static void PrintFirstLetter(string str)
        {
            Console.WriteLine("Enter position of word:");
            int position = Int32.Parse(Console.ReadLine());

            string[] words = str.Split(' ');

            Console.WriteLine(words[position - 1].Substring(0,1)); 
        }

        public static void PrintReverseOrder(string str)
        {
            string[] array = str.Split(' ');
            string strReverse = string.Empty;

            for (int i = array.Length-1; i >=0; i--)
            {

                strReverse += array[i] + ' ';
            }

            Console.WriteLine($"Reverse: {strReverse}");
        }

        public static void LengthOfWord(string str)
        {
            string[] word = str.Split(' ');
            int max = word[0].Length;
            int min = word[0].Length;

            for (int i = 0; i < word.Length; i++)
            {
                if (max < word[i].Length)
                    max = word[i].Length;
                if(min > word[i].Length)
                    min = word[i].Length;
            }

            Console.WriteLine($" Min length of word is {min}, max lenght of word is {max}");
        }
    }
}
