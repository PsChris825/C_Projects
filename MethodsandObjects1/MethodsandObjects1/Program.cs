using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjects1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 12345;

            employee.SayName();

            Console.ReadLine();
        }
    }
}
