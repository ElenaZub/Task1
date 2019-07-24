using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Arial : Mammal
    {
        public Arial(int age)
            : base(age)
        {
            this.WeightIncrease = 3;
        }

        public override void Move()
        {
            Console.WriteLine("Arial is flying.");
        }
    }
}
