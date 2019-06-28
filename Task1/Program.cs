using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public delegate double Calculate(double firstArgument, double secondArgument);


    public class Helper
    {
        public void Execute(Calculate del)
        {
            double firstArgument = 10;
            double secondArgument = 20;

            var calculationResult = del.Invoke(firstArgument, secondArgument);

            Console.WriteLine(calculationResult);
        }
    }

    class Calculator
    {

        public double Multyply(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

        public double Sum(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

        public double Divide(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Helper help = new Helper();
            Calculator calc = new Calculator();

            help.Execute(calc.Divide);
            help.Execute(calc.Sum);
            help.Execute(calc.Multyply);

            Console.ReadKey();
        }
    }
}
