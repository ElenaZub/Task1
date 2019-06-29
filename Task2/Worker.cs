using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Worker : User
    {
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                    Console.WriteLine("Invalid value of age!");
            }
        }

        public Worker(string name, int age, decimal salary)
            : base(name, age)
        {
            this.Salary = salary;
        }
    }
}
