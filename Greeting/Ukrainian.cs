using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Ukrainian : Human
    {
        public Ukrainian(string name) 
            : base(name)
        {
        }

        public override void SatHello()
        {
            Console.WriteLine($"Привіт! Я {this.Name}.");
        }
    }
}
