using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathOp math = new mathOp();
            int product;


            // ask to enter number
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());

            math.MathOperation(num1);

            Console.WriteLine("Enter first number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num3 = int.Parse(Console.ReadLine());

            math.OutPutParam(num2, num3, out product);

            int sumInt = math.Add(5, 10);
            Console.WriteLine(sumInt);
            double sumDouble = math.Add(4.21, 5.39);
            Console.WriteLine(sumDouble);

            Console.ReadLine();
        }
    }
}
