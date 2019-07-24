using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammals
{
    public class Mammal
    {
        public int Age { get; }

        public int Weight { get; private set; }

        public int FoodAmount { get; private set; }

        public int WeightIncrease { get;  set; }

        public Mammal(int age)
        {
            this.Age = age;
            this.Weight = 1;
        }

        public virtual void Eat(int foodAmount)
        {
            this.FoodAmount += foodAmount;
            this.Weight += this.WeightIncrease * this.FoodAmount / 5;
            this.FoodAmount %= 5;

            if (this.Age < 1)
            {
                Console.WriteLine($"{this.GetType().Name} drinks milk.");
            }
            else
                Console.WriteLine($"{this.GetType().Name} eats everything.");

        }

        public virtual void Move()
        {
            Console.WriteLine("Mammals moving");
        }
    }
}
