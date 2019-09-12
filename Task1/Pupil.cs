using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Pupil
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string School { get; private set; }

        public Pupil(string firstName, string lastName, string school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }
    }
}
