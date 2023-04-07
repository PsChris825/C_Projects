using System;


namespace BranchingAssignment.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight");
            string weight = Console.ReadLine();
            int Pweight = Convert.ToInt32(weight);

            if (Pweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter package width");
            string width = Console.ReadLine();
            int Pwidth = Convert.ToInt32(width);

            Console.WriteLine("Please enter package height");
            string height = Console.ReadLine();
            int Pheight = Convert.ToInt32(height);

            Console.WriteLine("Please enter package length");
            string length = Console.ReadLine();
            int Plength = Convert.ToInt32(length);


            if ( (Pheight + Plength + Pwidth) > 50 )
            {
               Console.WriteLine("Package is too big to be shipped via Package Express");
                Console.ReadLine();
                return;
            }
            

            double totalD = (Pweight * Pwidth * Pheight * Plength) / 100;


            Console.WriteLine("Your total for shipping this package is: " + "$" + totalD);

            Console.WriteLine("Thank you");

            Console.ReadLine();

          
        }
    }
}
