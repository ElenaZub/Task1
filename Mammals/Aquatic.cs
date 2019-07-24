using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Aquatic : Mammal
    {
        public Aquatic(int age)
            : base(age)
        {
            this.WeightIncrease = 4;
        }

        public override void Move()
        {
            Console.WriteLine("Aquatic is swiming.");
        }
    }
}
