using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Mammal
    {
        public int Age { get; }

        public int Weight { get; private set; }

        public int FoodAmount { get; private set; }

        public Mammal(int age)
        {
            this.Age = age;
            this.Weight = 1;
        }

        public void Eat(int foodAmount)
        {
            if (this.Age < 1)
            {
                Console.WriteLine("Mammal drinks milk");
            }
            else
                Console.WriteLine("Mammal eats everything");

            FoodAmount += foodAmount;
            Weight += FoodAmount / 5;
            FoodAmount %= 5;
        }
    }
}
