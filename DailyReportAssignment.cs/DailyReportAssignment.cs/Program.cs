using System;


namespace DailyReportAssignment.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);


            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be Specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursNum = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();

        }
    }
}