using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Arboreal : Mammal
    {
        public Arboreal(int age)
            : base(age)
        {
            this.WeightIncrease = 5;
        }

        public override void Move()
        {
            Console.WriteLine("Arboreal is climbing on the tree.");
        }
    }
}
