  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme_Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current date and time: {0}", now);

            //ask user for a number of hours
            int hours;
            do
            {
                Console.WriteLine("Please enter a number of hours:");
            } while (!int.TryParse(Console.ReadLine(), out hours));

            //calculate the future date and time 
            DateTime future = now.AddHours (hours);
            Console.WriteLine("In {0} hours it will be {1}", hours, future);

            Console.ReadLine();
        }
    }
}
