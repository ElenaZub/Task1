using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Manager
    {
        public Student GetStrudent(out string studentKey)
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
            studentKey = name + " " + surname;

            return new Student(name, surname, course, group, faculty);
        }

        public void PrintStudents(Dictionary<string, Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Dictionary is empty!");
            }
            else
            {
                foreach( var item in students)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Amount of students is: {students.Count}");
            }
        } 
    }
}
