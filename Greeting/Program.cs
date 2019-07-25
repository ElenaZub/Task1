using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Human[] human = new Human[]
            {
                new Ukrainian("Іван"),
                new Russian("Сергей"),
                new American("Tom")
            };

            foreach (var item in human)
            {
                item.SatHello();
            }
        }
    }
}
