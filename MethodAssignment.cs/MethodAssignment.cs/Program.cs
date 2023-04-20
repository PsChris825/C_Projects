using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment.cs
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            MathOp Math = new MathOp();

            Console.WriteLine("Please enter first number");
            string firstNum = Console.ReadLine();
            int NumOne = Int32.Parse(firstNum);

            Console.WriteLine("Please enter second number (press enter to skip)");
            string secondNum = Console.ReadLine();
            int Numtwo = secondNum == "" ? 20: int.Parse(secondNum);

            //Call the method wit htwo integer inputs
            int result1 = Math.PerformOp(NumOne, Numtwo);
            Console.WriteLine(result1);

            //Call the method with one integer input
            int result2 = Math.PerformOp(NumOne);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
