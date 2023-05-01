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
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            IQuittable quittable = employee;
            quittable.Quit();

            Employee<string> employee1 = new Employee<string>();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.Id = 123;
            employee1.Things = new List<string> { "apple", "banana", "cherry" };

            Employee<int> employee2 = new Employee<int>();
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.Id = 456;
            employee2.Things = new List<int> { 1, 2, 3 };


            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

        }
    }
}
