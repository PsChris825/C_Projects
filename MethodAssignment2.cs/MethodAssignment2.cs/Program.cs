using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps math = new MathOps();

            // Call the method with two parameters
            math.PerformOperation(5, 10);

            // Call the method with named parameters
            math.PerformOperation(num1: 2, num2: 40);

            Console.ReadLine();

        }
    }
}
