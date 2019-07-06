using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Manager
    {
        public Student GetStrudent()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter surname:");
            string surname = Console.ReadLine();


            Console.WriteLine("Enter course(number):");
            int course = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter group:");
            string group = Console.ReadLine();

            Console.WriteLine("Enter faculty:");
            string faculty = Console.ReadLine();

            return new Student(name, surname, course, group, faculty);
        }

        public void PrintStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {students[i]}");
                }
                Console.WriteLine($"Count of students is: {students.Count}");
            }
        }
    }
}
