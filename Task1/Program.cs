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
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            Manager action = new Manager();
            Student someStudent = new Student(); 

            while (true)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Remove student");
                Console.WriteLine("3. Find student");
                Console.WriteLine("4. Print students");
                Console.WriteLine("Enter number of menu:");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        string key = String.Empty;
                        someStudent = action.GetStrudent(out key);
                        students.Add(key, someStudent);
                        break;
                    case 2:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Dictionary is empty!");
                        }
                        else
                        {
                            while (true)
                            {
                                Console.WriteLine("Enter name and surname of student that you want to remove from dictionary:");
                                string keyString = Console.ReadLine();

                                bool check = students.TryGetValue(keyString, out someStudent);
                                if (check)
                                {
                                    students.Remove(keyString);
                                }
                                else
                                    Console.WriteLine("There is no such key in dictionary");
                                break;
                            }
                        }
                        break;
                    case 3:
                        if (students.Count == 0)
                        {
                            Console.WriteLine("Dictionary is empty!");
                        }
                        else
                        {
                            Console.WriteLine("Enter name and surname of student that you want to find in dictionary:");
                            string keyValue = Console.ReadLine();

                            bool done = students.TryGetValue(keyValue, out someStudent);

                            if (done)
                            {
                                Console.WriteLine(someStudent);
                            }
                            else
                                Console.WriteLine("Student is not exists!");
                        }
                        break;
                    case 4:
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
