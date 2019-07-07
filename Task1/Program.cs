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
            DeferedExemple();
        }

        public static void DeferedExemple()
        {
            var employees = new List<Employee>()
            {
                new Employee("Elena", "Zub", 21, "F", CompanyName.Intetics),
                new Employee("Ivan", "Avanova", 23, "M", CompanyName.Philips),
                new Employee("Tanya", "Rijik", 30, "F", CompanyName.Intetics),
                new Employee("Petr", "Petrov", 35, "M", CompanyName.Meizu),
                new Employee("Oleg", "Reshetilo", 30, "M", CompanyName.Intetics),
                new Employee("Kirill", "Novikov", 31,  "M", CompanyName.Philips),
                new Employee("Olga", "Pavlenko", 32, "F", CompanyName.Intetics),
                new Employee("Vlad", "Radchenko", 24, "M", CompanyName.Intetics)
            };

            var orderedEmployees = employees.OrderBy(someEmployee => someEmployee.LastName)
                     .ThenBy(someEmployee => someEmployee.FirstName);
            Display(orderedEmployees);

            var ageEmployees = employees.Where(someEmployee => someEmployee.Age > 30);
            Display(ageEmployees);

            var maleEmployees = employees.Where(someEmployee => someEmployee.Gender == "M");
            Display(maleEmployees);

            var femaleEmployees = employees.Where(someEmployee => someEmployee.Gender == "F");
            Display(femaleEmployees);

            var nameEmployees = employees
                .Select(someEmployee => someEmployee.FirstName + " " + someEmployee.LastName);
            foreach (var item in nameEmployees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 30));
            var femaleNameEmployees = employees
                .Where(someEmployee => someEmployee.Gender == "F" && someEmployee.FirstName[0] == 'O' && someEmployee.Age >20)
                                               .Select(someEmployee => someEmployee.LastName);
            foreach (var item in femaleNameEmployees)
            {
                Console.WriteLine(item);
            }

            //    var companyMembers = employees
            //                    .GroupJoin(employees, cmp => cmp.Company, count => count.Company,
            //                    (cmp, count) => new { Company = cmp.Company, NibContains = count.Count() });

            var firstEmployee = employees.First();
            Console.WriteLine(firstEmployee);
        }

        public static void Display(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 30));
        }
    }
}
