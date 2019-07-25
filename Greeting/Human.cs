using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public abstract class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            this.Name = name;
        }

        public abstract void SatHello();
    }
}
