using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FileContent
    {
        private string PATH = @"D:\Info.txt";

        public void Execute()
        {
            string text = GetString(PATH);

            CountLineAmount(text);
            CountSymbolAmount(text);
            CountWordAmount(text);
        }

        public string GetString(string path)
        {
            return File.ReadAllText(path);
        }

        public void CountSymbolAmount(string str)
        {
            Console.WriteLine($"Count of symbol in text is {str.Length}");
        }

        public void CountLineAmount(string str)
        {
            string[] line = str.Split('\n');

            Console.WriteLine($"Count of line in text is {line.Length}");
        }

        public void CountWordAmount(string str)
        {
            char[] delimiters = new char[] { ' ', '\n' };
            string[] word = str.Split(delimiters);

            Console.WriteLine($"Count of word in text is {word.Length}");
        }
    }
}
