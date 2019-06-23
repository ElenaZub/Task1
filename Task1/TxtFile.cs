using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TxtFile
    {
        private const string PATH = @"C:\Temp";
        private string fileName = "userText.txt";

        public void Execute()
        {
            string text = EnterText();
            WriteTextToFile(PATH, fileName, text);
        }

        public void WriteTextToFile(string path, string name, string str)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.WriteAllText(path + "\\" + name, str);

            Console.WriteLine("File with text is saved!");
        }

        public string EnterText()
        {
            Console.WriteLine("Enter text:");
            return Console.ReadLine();
        }
    }
}
