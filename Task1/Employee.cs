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

        public string Gender { get; set; }

        public Employee(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }
    }
}
