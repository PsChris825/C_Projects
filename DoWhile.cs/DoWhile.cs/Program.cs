using System;


namespace DoWhile.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 76;
            
            do
            {
                switch (number)
                {
                    case 43:
                        Console.WriteLine("You guessed 43. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 56:
                        Console.WriteLine("You guessed 56. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 32:
                        Console.WriteLine("You guessed 32. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 76:
                        Console.WriteLine("You guessed 76. That is correct!");
                        isGuessed |= true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);

            Console.Read();
        }

            
    }
}
