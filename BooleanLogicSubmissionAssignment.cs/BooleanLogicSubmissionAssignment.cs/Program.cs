using System;


namespace BooleanLogicSubmissionAssignment.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your Age");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool dui1 = bool.Parse(dui) ;
            Console.WriteLine("How Many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tikAmount = Convert.ToInt32(tickets);
            Console.WriteLine("Qualified?");
            bool qualified = (age1 >= 32 && dui1!=true && tikAmount <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
