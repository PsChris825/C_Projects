using System;
using System.Text;

namespace Strings.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse \n Hello on a new line, \n \t hello on a tab";
            //string filename = @"C:\Users\Jesse";

            //bool trueOrfalse = name.Contains("s");
            //trueOrfalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //string are immutable 

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
