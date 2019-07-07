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
            UnDeferedExemple();
            //DeferedExemple();
        }

        public static void DeferedExemple()
        {
            var employees = new List<Employee>()
            {
                new Employee("Elena", "Zub", "F"),
                new Employee("Ivan", "Ivanova", "M"),
                new Employee("Yana", "Vasyna", "F"),
                new Employee("Petr", "Petrov", "F")
            };
            employees.ToList();
            var maleEmployees = employees.Where(employee => employee.Gender == "M");
            Display(maleEmployees);
            employees.Add(new Employee("Sasha", "Levchenko", "M"));
            Display(maleEmployees);
        }

        public static void UnDeferedExemple()
        {
            var employees = new List<Employee>()
            {
                new Employee("Elena", "Zub", "F"),
                new Employee("Ivan", "Ivanova", "M"),
                new Employee("Yana", "Vasyna", "F"),
                new Employee("Petr", "Petrov", "F")
            };
            var maleEmployees = employees.Where(employee => employee.Gender == "M").ToList();
            Display(maleEmployees);
            employees.Add(new Employee("Sasha", "Levchenko", "M"));
            Display(maleEmployees);
        }

        public static void Display(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.WriteLine(new String('-', 30));
        }
    }
}
