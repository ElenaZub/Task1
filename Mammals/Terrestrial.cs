using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Terrestrial : Mammal
    {
        public Terrestrial(int age)
            : base(age)
        {
            this.WeightIncrease = 1;
        }

        public override void Move()
        {
            Console.WriteLine("Terrestrial is walking.");
        }
    }
}
