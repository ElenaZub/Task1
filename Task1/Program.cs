using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Manager action = new Manager();

            while (true)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Remove student");
                Console.WriteLine("3. Print students");
                Console.WriteLine("Enter number of menu:");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        students.Add(action.GetStrudent());
                        break;
                    case 2:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("List is empty!");
                        }
                        else
                        {
                            while (true)
                            {
                                Console.WriteLine("Enter number of student that you want to remove from list:");
                                int number = Int32.Parse(Console.ReadLine());
                                if (number > students.Count || number <= 0)
                                {
                                    Console.WriteLine("You enter wrong number!");
                                }
                                else
                                    students.Remove(students[number - 1]);
                                break;
                            }
                        }
                        break;
                    case 3:
                        action.PrintStudents(students);
                        break;
                    default:
                        Console.WriteLine("You entered wrong number of menu!");
                        break;
                }
            }
        }
    }
}
