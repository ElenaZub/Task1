using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWithColor printWithColor = new PrintWithColor();
            printWithColor.Execute();
            
            Console.ReadKey();
        }
    }
}
