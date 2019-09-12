using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Manager
    {
        public void DeferedExample()
        {
            var employees = new Employee[]
            {
                new Employee("Elena", "Zub", 21, "F", CompanyName.Intetics),
                new Employee("Tanya", "Ryjik", 30, "F", CompanyName.Intetics),
                new Employee("Petr", "Petrov", 35, "M", CompanyName.Meizu),
                new Employee("Oleg", "Reshetilo", 30, "M", CompanyName.Intetics),
                new Employee("Kirill", "Novikov", 31,  "M", CompanyName.Philips),
                new Employee("Olga", "Pavlenko", 32, "F", CompanyName.Intetics),
                new Employee("Vlad", "Stepanov", 24, "M", CompanyName.Intetics)
            };


            var orderedEmployees = employees.OrderBy(someEmployee => someEmployee.FirstName)
                     .ThenBy(someEmployee => someEmployee.LastName).ToList();

            Console.WriteLine("Alphabetical order:");
            Display(orderedEmployees);

            var ageEmployees = employees.Where(someEmployee => someEmployee.Age > 30);

            Console.WriteLine("More then 30:");
            Display(ageEmployees);

            var maleEmployees = employees.Where(someEmployee => someEmployee.Gender == "M");

            Console.WriteLine("Only man:");
            Display(maleEmployees);

            var femaleEmployees = employees.Where(someEmployee => someEmployee.Gender == "F");

            Console.WriteLine("Only woman:");
            Display(femaleEmployees);

            var nameEmployees = employees
                .Select(someEmployee => someEmployee.FirstName + " " + someEmployee.LastName);

            Console.WriteLine("Name and surname:");
            foreach (var item in nameEmployees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 30));

            var femaleNameEmployees = employees
                .Where(someEmployee => someEmployee.Gender == "F" && someEmployee.FirstName[0] == 'O' && someEmployee.Age >20)
                                               .Select(someEmployee => someEmployee.LastName);

            Console.WriteLine("Surnames of women that are older than 20 and \"O\" as the first letter of name:");
            foreach (var item in femaleNameEmployees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 30));

            var companyMembers = employees
                            .GroupBy(employee => employee.Company)
                            .Select(employee => new { Company = employee.Key, EmployeeCount = employee.Count()});

            Console.WriteLine("Count of employee in each company:");
            foreach (var item in companyMembers)
            {
                Console.WriteLine(item.Company + " " + item.EmployeeCount);
            }
            Console.WriteLine(new String('-', 30));

            var firstMember = employees
                            .GroupBy(employee => employee.Company)
                            .Select(employee => employee.First());

            Console.WriteLine("First member in each company:");
            Display(firstMember);

            var lastMember = employees
                            .GroupBy(employee => employee.Company)
                            .Select(employee => employee.Last());

            Console.WriteLine("Last member in each company:");
            Display(lastMember);

            var firstWithIfMember = employees
                            .Where(employee => employee.Age > 25)
                            .GroupBy(employee => employee.Company)
                            .Select(employee => employee.First() );

            Console.WriteLine("Last member older than 25 in each company:");
            Display(firstWithIfMember);

            var pupilEmloyee = employees
                            .Where(employee => employee.FirstName == "Oleg")
                            .Select(employee => new  Pupil(employee.FirstName, employee.LastName, "Middle"));

            Console.WriteLine("Create example:");
            foreach (var item in pupilEmloyee)
            {
                Console.WriteLine($"{item.FirstName}  {item.LastName} {item.School}");
            }
        }

        public void Display(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 30));
        }

        public void Join()
        {
            var firstEmployeesList = new List<Employee>
            {
                new Employee("Elena", "Zub", 21, "F", CompanyName.Intetics),
                new Employee("Ivan", "Avanova", 23, "M", CompanyName.Philips),
                new Employee("Tanya", "Ryjik", 30, "F", CompanyName.Intetics),
                new Employee("Ivan", "Petrov", 35, "M", CompanyName.Meizu),
                new Employee("Oleg", "Reshetilo", 30, "M", CompanyName.Intetics),
                new Employee("Kirill", "Novikov", 31,  "M", CompanyName.Philips),
                new Employee("Olga", "Pavlenko", 32, "F", CompanyName.Intetics),
                new Employee("Vlad", "Stepanov", 24, "M", CompanyName.Intetics)
            };

            var secondEmployeesList = new List<Employee>
            {
                new Employee("Elena", "Ivanova", 21, "F", CompanyName.Intetics),
                new Employee("Ivan", "Avanova", 23, "M", CompanyName.Philips),
                new Employee("Tanya", "Rijik", 30, "F", CompanyName.Intetics),
                new Employee("Petr", "Petrov", 35, "M", CompanyName.Meizu),
                new Employee("Oleg", "Reshetilo", 30, "M", CompanyName.Intetics),
                new Employee("Kirill", "Novikov", 31,  "M", CompanyName.Philips),
                new Employee("Yana", "Pavlenko", 32, "F", CompanyName.Intetics),
                new Employee("Stepan", "Pavlov", 24, "M", CompanyName.Intetics)
            };

            var employeesWithDuplicates = firstEmployeesList.Concat(secondEmployeesList);
            Console.WriteLine("With duplicates:");
            Display(employeesWithDuplicates);

            var employeesWithoutDuplicates = firstEmployeesList.Union(secondEmployeesList).ToList();
            Console.WriteLine("Without duplicates:");
            Console.WriteLine(employeesWithoutDuplicates);
        }
    }
}
