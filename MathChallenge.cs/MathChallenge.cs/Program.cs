using System;


namespace MathChallenge.cs
{
    internal class Program
    {
        static void Main()
        {
            //Basic Math
            int num1 = 3;
            int num2 = 6;
            int total = num1 + num2;
            Console.WriteLine(total);
            int difference = num1 - num2;
            Console.WriteLine(difference);
            int product = num1 * num2;
            Console.WriteLine(product);
            int quoient = num1 / num2;
            Console.WriteLine(quoient);
            int remainder = num1 % num2;
            Console.WriteLine(remainder);
            int remain = num1 % 2;
            Console.WriteLine(remain);

            //Math with different data types

            //int and float
           
            int num3 =  7;
            float num4 = 10.5f;

            float change = num3 + num4;
            Console.WriteLine(change);

            int changeInt = num3 + (Int32)num4;
            Console.WriteLine(changeInt);

            //float and double

            double num5 = 7.0323453;

            double changeDouble = num5 + num4;
            Console.WriteLine(changeDouble);

            float changeFloat = (float)num5 + num4;
            Console.WriteLine(changeFloat);

            //Math with strings

            string firstName = "Chris";
            string lastName = "Sampson";
            Console.WriteLine(firstName + lastName);

            Console.WriteLine(firstName + num3);

            //Boolean Logic (&&)
            int packageWidth = 10;
            int packageHeight = 25;
            bool tooBig = (packageHeight > 25 && packageWidth > 25);
            Console.WriteLine(tooBig);

            //Boolean Ligic (||)
            bool tooBig2 = (packageHeight > 25 || packageWidth > 25);
            Console.WriteLine(tooBig2);

            int bankAccountBalance = 500;
            bool isInARockBand = false;
            string name = "Jesse";
            bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Jesse");
            Console.WriteLine(isReallyCool);


          

            Console.ReadLine();
        }
    }
}
