using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract_Assignment_1
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit their job", FirstName, LastName);
        }

        public static bool operator ==(Employee a, Employee b)
        {
            if (a is null &&  b is null) 
            {
                return true;
            }
            else if a is null || b is null) 
            {
                return false;
            }
            else
            {
                return a.Id == b.Id;
            }
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b);
        }
        
    }

}
