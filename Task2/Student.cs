using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student : User
    {
        private decimal scholarship;

        public decimal Scholarship
        {
            get
            {
                return scholarship;
            }
            set
            {
                if (value > 0)
                {
                    scholarship = value;
                }
                else
                    Console.WriteLine("Invalid value of  scholarship!");
            }
        }

        public Student(string name, int age, decimal scholarship)
            : base(name, age)
        {
            this.Scholarship = scholarship;
        }
    }
}
