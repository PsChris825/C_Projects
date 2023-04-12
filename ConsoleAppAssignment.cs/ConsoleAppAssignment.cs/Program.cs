using System;
using System.Collections.Generic;


class Program
{
  static void Main(string[] args)
  {
        ////Part 1
        //string[] manufacture = { "Honda ", "Nissan ", "BMW ", "Porsche ", "Audi ", "Ford ", };

        //Console.WriteLine("Please type a color");
        //string color = Console.ReadLine();

        //for (int i = 0; i < manufacture.Length; i++)
        //{
        //    manufacture[i] +=  color;
        //    Console.WriteLine(manufacture[i]);
        //}

        ////Part 2 Infinite loop
        //int j = 0;
        //while (true)
        //{
        //    Console.WriteLine("Cars are amazing!", j);
            
        //    j++;

        //    //added an if statement to break the loop
        //    if (j >= 5) 
        //    {
        //        break;
        //    }
        //}
        
        ////Part 3
        //for (int C = 0; C < 7; C++) 
        //{
        //    Console.WriteLine("I go racing regularly");
        //}

        //for (int D = 0; D <= 1;  D++)
        //{
        //    Console.WriteLine("I love the Porsche 959");
        //}

        ////Part 4
        //List<string> manufacturer = new List<string>() { "Honda", "Audi", "Mercedes", "Subaru", "Acura"};

        //Console.WriteLine("Type a car manufacturer");
        //string includes = Console.ReadLine();

        //var matchManufacturer = -1;

        //for (int E = 0;  E < manufacturer.Count; E++) 
        //{ 
        //    if (manufacturer[E] == includes)
        //    {
        //        matchManufacturer = E;
        //        break;
        //    }
        //}

        //if (matchManufacturer >= 0)
        //{
        //    Console.WriteLine("Index: " +  matchManufacturer);
        //}
        //else
        //{
        //    Console.WriteLine("This is not included in the list");
        //}

        //Part 5
        //List<string> same = new List<string>() { "cat", "dog", "dog", "iguana", "hamster", "snake"};
        
        //Console.WriteLine("Please type a type of pet");
        //string pet = Console.ReadLine();

        //var petmatch = -1;

        //for (int F = 0; F < same.Count; F++)
        //{
        //    if (same[F] == pet) 
        //    {
        //        petmatch = F;
        //        break;
        
        //    }
        //}
        
        //if (petmatch >= 0)
        //{
        //    Console.WriteLine("Index: " + petmatch);
        //}
        //else
        //{
        //    Console.WriteLine("This is not included in the list");
        //}

        //Part 6
        List<string> names = new List<string>() { "Chris", "John", "Justin", "D", "Chris"};

        List<string> names2 = new List<string>();

        foreach (string name in names) 
        {
            if (names2.Contains(name))
            {
                Console.WriteLine(name + " Already exists in list");
            }
            else
            {
                names2.Add(name);
                Console.WriteLine(name);
            }
        }


       


        Console.ReadLine();
  }
}

