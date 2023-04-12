using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
    {
        //int[] testScore = { 88, 99, 65, 70, 82, 34, 91, 90, 84 };

        //for (int i = 0; i < testScore.Length; i++) 
        //{
        //    if (testScore[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScore[i]);
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "J", "B", "C", "D" };

        //for (int i = 0; i < names.Length; i++) 
        //{
        //    if (names[i] == "J")
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(88);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(85);

        //foreach (int score in testScores) 
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing Test score: " +  score);
        //    }
        //}
        //Console.ReadKey();  

        List<string> list = new List<string>() { "Jesse", "Eric", "Chris", "Adam" };

        foreach (var item in list) 
        {
            if (item == "Jesse")
            {
                Console.WriteLine(item);
            }
        }
        Console.ReadLine();
    }
}
