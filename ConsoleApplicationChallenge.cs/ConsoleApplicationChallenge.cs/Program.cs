using System;


namespace ConsoleApplicationChallenge.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Type Number to multiply with 50");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);
            Console.WriteLine(number1 * 50);

            Console.WriteLine("Type new number to add to 25");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);
            int numAdd = 25;
            Console.WriteLine(number2 + numAdd);

            Console.WriteLine("Type in another number to divide by 12.5");
            string num3 = Console.ReadLine();
            int number3 = Convert.ToInt32(num3);
            Console.WriteLine(number3 / 12.5);

            Console.WriteLine("Type number to see if greater than 50");
            string num4 = Console.ReadLine();
            int number4 = Convert.ToInt32(num4);
            bool greaterThan = number4 > 50;
            Console.WriteLine(greaterThan);

            Console.WriteLine("Type in last number to divide by 7");
            string num5 = Console.ReadLine();
            int number5 = Convert.ToInt32(num5);
            Console.WriteLine(number5 % 7);

            Console.ReadLine();

        }
    }
}
