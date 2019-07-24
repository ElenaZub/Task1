using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
            {
                new Triangle(2, 4, 5, 3),
                new Circle(4, 2, 3),
                new Square(2, 4, 5)
            };

            foreach (var item in figures)
            {
                item.Draw();
            }        
        }
    }    
}
