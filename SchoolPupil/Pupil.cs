using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPupil
{
    public class Pupil
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int School { get; set; }

        public string ClassNumber { get; set; }

        public Pupil(string firstName, string lastName, int age, int school, string classNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.School = school;
            this.ClassNumber = classNumber;
        }
    }
}
