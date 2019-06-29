﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Feeder
    {
        public void Feed(Mammal[] mammals)
        {
            Random rand = new Random();

            int foodAmount = 0;

            foreach (var item in mammals)
            {
                foodAmount = rand.Next(1, 20);
                item.Eat(foodAmount);

                Console.WriteLine($"{item.GetType().Name} eats {foodAmount}. Its weight is {item.Weight}.");
                Console.WriteLine(new String('-', 30));
            }
        }
    }
}
