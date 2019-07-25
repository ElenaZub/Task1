using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Russian : Human
    {
        public Russian(string name) 
            : base(name)
        {
        }

        public override void SatHello()
        {
            Console.WriteLine($"Привет! Я {this.Name}.");
        }
    }
}
