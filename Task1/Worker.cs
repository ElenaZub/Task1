using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Worker
    {

        private int age = 1;

        public string Name { get; set; }

        public decimal Salary { get; set; }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    age = value;
                }
            }
        }

        public Worker(string name, int age, decimal salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
    }
}
