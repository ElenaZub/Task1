using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        public string FirstName{ get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public CompanyName Company { get; set; }

        public Employee(string firstName, string lastName, int age, string gender, CompanyName company)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
        }

        public override string ToString()
        {
            return $"{this.LastName} {this.FirstName} {this.Age} {this.Gender} {this.Company}";
        }
    }
}
