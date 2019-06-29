using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Ivan", 25, 1000);
            Worker worker2 = new Worker("Vasya", 26, 2000);

            Console.WriteLine($"Sum of {worker1.Name}'s and {worker2.Name}'s salary is {worker1.Salary + worker2.Salary}");

            Student student1 = new Student("Petya", 18, 1300);
            Student student2 = new Student("Alex", 20, 1800);

            Console.WriteLine($"Sum of {student1.Name}'s and {student2.Name}'s salary is {student1.Scholarship + student2.Scholarship}");

            Driver driver1 = new Driver("Nick", 50, 10000, 30, Category.A);
            Driver driver2 = new Driver("Sam", 30, 8000, 10, Category.B);

            Console.WriteLine($"Sum of {driver1.Name}'s and {driver2.Name}'s driving experience is {driver1.DrivingExperience + driver2.DrivingExperience}");

            Console.ReadKey();
        }
    }
}
