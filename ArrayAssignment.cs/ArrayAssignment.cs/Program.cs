using System;
using System.Collections.Generic;


namespace ArrayAssignment.cs
{
    class Program
    {
        static void Main()
        {
            string[] arrayString = { "chris", "lauren", "katie", "jojo", "Goldie" };

            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8 };

            List<string> stringList = new List<string>();
            stringList.Add("Porsche");
            stringList.Add("Audi");
            stringList.Add("toyota");
            stringList.Add("Nissan");
            stringList.Add("Honda");

            Console.WriteLine("Choose an index number in the string array");
            string index1 = Console.ReadLine();
            int indexS1 = Convert.ToInt32(index1);

            if (indexS1 < 0 || indexS1 > arrayString.Length - 1)
            {
                Console.WriteLine("User's select index does not exist");
            }
            else
            {
                Console.WriteLine(arrayString[indexS1]);
            }

            Console.WriteLine("Choose an index number in the int array");
            string index2 = Console.ReadLine();
            int indexI2 = Convert.ToInt32(index2);

            if (indexI2 < 0 || indexI2 > arrayInt.Length - 1)
                {
                Console.WriteLine("User's select index does not exist");
            }
            else
            {
                Console.WriteLine(arrayInt[indexI2]);
            }

            Console.WriteLine("Choose an index of the list");
            string index3 = Console.ReadLine();
            int indexL3 = Convert.ToInt32(index3);

            if (indexL3 < 0 || indexL3 > stringList.Count - 1)
            {
                Console.WriteLine("User's select index does not exist");
            }
            else
            {
                Console.WriteLine(stringList[indexL3]);
            }


            Console.ReadLine();
        }
    }
}
