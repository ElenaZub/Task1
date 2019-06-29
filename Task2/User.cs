using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class User
    {
        private string name;

        private int age;

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                    Console.WriteLine("Invalid value of age!");
            }
        }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
