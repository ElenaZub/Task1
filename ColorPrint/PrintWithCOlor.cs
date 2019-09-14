using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPrint
{
    public class PrintWithColor
    {

        public void Execute()
        {
            string textInput = EnterText();
            string myColor = ChooseColor();

            Print(textInput, myColor);
        }

        public void Print(string text, string color)
        {
            string myColor = Enum.GetName(typeof(Color), color);

            foreach (var value in Enum.GetValues(typeof(Color)))
            {
                if (myColor == value)
                {
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), myColor);
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Wrong value");
                    break;
                }
            }
        }

        public string EnterText()
        {
            Console.WriteLine("Enter text:");

            string text = Console.ReadLine();
            return text;
        }

        public string ChooseColor()
        {
            Console.WriteLine($"Choose a color ({Color.Blue}, {Color.Red}, {Color.Green}, {Color.Grey}, {Color.White}, {Color.Yellow}):");

            string color = Console.ReadLine();

            return color;
        }
    }
}
