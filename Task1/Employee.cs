using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee
    {
        public string FirstName { get; set; }

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
            return $"{this.FirstName} {this.LastName} {this.Age} {this.Gender} {this.Company}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        public bool Equals(Employee employee)
        {
            return employee != null
                && this.FirstName == employee.FirstName
                && this.LastName == employee.LastName
                && this.Age == employee.Age
                && this.Gender == employee.Gender
                && this.Company == employee.Company;
        }

        public override int GetHashCode()
        {
            return new Employee(this.FirstName, this.LastName, this.Age, this.Gender, this.Company).GetHashCode();
        }
    }
}
