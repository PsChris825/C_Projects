using System;
using System.Text;

namespace StringChallenge.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Chris";
            string city = "San Mateo";
            string age = "26";

            city = city.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(name + "\n");
            sb.AppendLine(city);
            sb.AppendLine(age);
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
