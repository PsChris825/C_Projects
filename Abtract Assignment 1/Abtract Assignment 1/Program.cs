using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee<string> employee = new Employee<string>();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";

            //IQuittable quittable = employee;
            //quittable.Quit();

            //Employee<string> employee1 = new Employee<string>();
            //employee1.FirstName = "Sample";
            //employee1.LastName = "Student";
            //employee1.Id = 123;
            //employee1.Things = new List<string> { "apple", "banana", "cherry" };

            //Employee<int> employee2 = new Employee<int>();
            //employee2.FirstName = "Sample";
            //employee2.LastName = "Student";
            //employee2.Id = 456;
            //employee2.Things = new List<int> { 1, 2, 3 };


            //foreach (string thing in employee1.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //foreach (int thing in employee2.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Smith", Id = 1 },
                new Employee { FirstName = "Jane", LastName = "Doe", Id = 2 },
                new Employee { FirstName = "John", LastName = "Smith", Id = 3 },
                new Employee { FirstName = "Sarah", LastName = "Johnson", Id = 4 },
                new Employee { FirstName = "Mike", LastName = "Peterson", Id = 5 },
                new Employee { FirstName = "Joe", LastName = "Johnson", Id = 6 },
                new Employee { FirstName = "Lauren", LastName = "Larson", Id = 7 },
                new Employee { FirstName = "Tom", LastName = "Johnson", Id = 8 },
                new Employee { FirstName = "Hannah", LastName = "Spears", Id = 9 },
                new Employee { FirstName = "Joanna", LastName = "Johnson", Id = 10 }
            };

            // Using a foreach loop
            List<Employee> joes1 = new List<Employee>();

            foreach (Employee employee in employees)
            {
               if (employee.FirstName == "Joe")
               {
                  joes1.Add(employee);
               }
            }

            Console.WriteLine("Joe employees using foreach:");
            foreach (Employee joe in joes1)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " (id " + joe.Id + ")");
            }

            // Using a lambda expression
            List<Employee> joes2 = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine();
            Console.WriteLine("Joe employees using lambda expression:");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " (id " + joe.Id + ")");
            }

            // Using a lambda expression to filter by Id
            List<Employee> highIds = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine();
            Console.WriteLine("Employees with Id greater than 5 using lambda expression:");
            foreach (Employee employee in highIds)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " (id " + employee.Id + ")");
            }


            Console.ReadLine();

        }
    }
}
