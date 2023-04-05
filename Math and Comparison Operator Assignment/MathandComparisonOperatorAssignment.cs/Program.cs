using System;


namespace MathandComparisonOperatorAssignment.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string rate1 = Console.ReadLine();
            int num1 = Convert.ToInt32(rate1);
            Console.WriteLine("Hours Worked Per Week?");
            string hours1 = Console.ReadLine();
            int num2 = Convert.ToInt32(hours1);
            int annual1 = num1 * num2 * 51;

            Console.WriteLine("Hourly Rate?");
            string rate2 = Console.ReadLine();
            int num3 = Convert.ToInt32(rate2);
            Console.WriteLine("Hours Worked Per Week?");
            string hours2 = Console.ReadLine();
            int num4 = Convert.ToInt32(hours1);
            int annual2 = num3 * num4 * 51;

            Console.WriteLine("Annual salary of Person 1: " + Environment.NewLine + annual1);
            Console.WriteLine("Annual salary of Person 2: " + Environment.NewLine + annual2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compare = annual1 > annual2;
            Console.WriteLine(compare);

            Console.ReadLine();
        }
    }
}
