using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    enum DaysofWeek
    {
        Monday,
        Tuesday,
        Wednesday, 
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter the current day of the week:");
            string input = Console.ReadLine();
            DaysofWeek currentDay = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), input, true);
            Console.WriteLine("Current day is : {0}", currentDay);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter an actual day of the week.");
        }

        Console.ReadLine();

    }
}
