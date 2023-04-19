using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("AddFive: " + MathClass.AddFive(num));
            Console.WriteLine("DivideTen: " + MathClass.DivideTen(num));
            Console.WriteLine("MultiplyTwo: " + MathClass.MultiplyTwo(num));

            Console.ReadLine();
        }
    }
}
