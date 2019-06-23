using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FolderInfo
    {
        private const string PATH = @"D:\home";

        public void Execute()
        {
            int folderAmount = 0;
            double filesSize = GetFolderInfo(PATH, ref folderAmount);

            Console.WriteLine(new String('-', 70));
            Console.WriteLine($"Number of folders: {folderAmount}");
            Console.WriteLine($"Size of files in folders: {filesSize}");
        }

        public double GetFolderInfo(string path, ref int folderAmount)
        {
            double size = 0;
            string[] folder = Directory.GetDirectories(path);
            string[] file = Directory.GetFiles(path);

            foreach (var item in file)
            {
                FileInfo info = new FileInfo(item);
                size += info.Length;
            }

            if (folder.Length == 0)
            {
                return size;
            }
            else
            {
                foreach (var item in folder)
                {
                    folderAmount++;
                    size += GetFolderInfo(item, ref folderAmount);
                }
            }
            return size;
        }
    }
}
