using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPupil
{
    public class Manager
    {
        private Pupil[] pupils;

        public void CreateGroup()
        {
            this.pupils = new Pupil[5];

            this.pupils[0] = new Pupil("Olga", "Ivanova", 9, 159, "3-B");
            this.pupils[1] = new Pupil("Ivan", "Petrov", 15, 159, "10-B");
            this.pupils[2] = new Pupil("Nick", "Smolov", 12, 159, "7-B");
            this.pupils[3] = new Pupil("Petr", "Petrov", 6, 159, "1-A");
            this.pupils[4] = new Pupil("Anna", "Ivanov", 13, 159, "8-C");
        }

        public void PrintInTable()
        {
            Console.WriteLine(String.Format("{0, 5} {1, 15} {2, 10} {3,10} {4,10} ", String.Empty,"Name",  "Age", "School", "Class"));

            for (int i = 0; i < this.pupils.Length; i++)
            {
                Console.WriteLine(String.Format("{0, 5} {1, 15} {2, 10} {3,10} {4,10} ", i + 1, this.pupils[i].FirstName + " " + this.pupils[i].LastName, this.pupils[i].Age, this.pupils[i].School, this.pupils[i].ClassNumber));
            }
        }

        public void Execute()
        {
            CreateGroup();
            PrintInTable();
        }
    }
}
