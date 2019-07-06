using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Course { get; set; }

        public string Group { get; set; }

        public string Faculty { get; set; }

        private Queue<string> myTask;

        private Stack<string> myBooks;

        public Student()
        {
        }

        public Student(string firstName, string lastName, int course, string group, string faculty)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Course = course;
            this.Group = group;
            this.Faculty = faculty;
            this.myTask = new Queue<string>();
            this.myBooks = new Stack<string>();
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} Surname: {this.LastName} Course: {this.Course} Group: {this.Group} Faculty: {this.Faculty}";
        }
        
        public void AddTask(string taskName)
        {
            myTask.Enqueue(taskName);
        }

        public void CompliteTask()
        {
            var tmp = myTask.Dequeue();
            Console.WriteLine($"\"{tmp}\" is done!");
        }

        public void PrintTask()
        {
            foreach (var item in myTask)
            {
                Console.WriteLine(item);
            }
        }

        public void TakeBook(string bookName)
        {
            myBooks.Push(bookName);
            Console.WriteLine($"Student take book \"{bookName}\" from library.");
        }

        public void GiveBackBook()
        {
            var tmp = myBooks.Pop();
            Console.WriteLine($" Student give back \"{tmp}\" to the library.");
        }

        public void PrintBook()
        {
            foreach (var item in myBooks)
            {
                Console.WriteLine(item);
            }
        }
    }
}
