using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer input
            int intResult = mathOps.PerformOperation(5);
            Console.WriteLine("Result of integer operation: " + intResult);

            // Call the second method with a decimal input
            int decimalResult = mathOps.PerformOperation(3.14159);
            Console.WriteLine("Result of decimal operation: " + decimalResult);

            // Call the third method with a string input
            int stringResult = mathOps.PerformOperation("25");
            Console.WriteLine("Result of string operation: " + stringResult);

            Console.ReadLine();
        }
        
    }
    
}
