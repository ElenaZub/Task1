using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class American : Human
    {
        public American(string name)
            : base(name)
        {
        }

        public override void SatHello()
        {
            Console.WriteLine($"Hi! I am {this.Name}.");
        }
    }
}
