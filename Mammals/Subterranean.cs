using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Subterranean : Mammal
    {
        public Subterranean(int age)
            : base(age)
        {
            this.WeightIncrease = 2;
        }

        public override void Move()
        {
            Console.WriteLine("Subterranean is digging.");
        }
    }
}
