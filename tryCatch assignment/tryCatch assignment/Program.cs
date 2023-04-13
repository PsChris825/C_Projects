using System;
using System.Collections;
using System.Collections.Generic;


namespace tryCatch_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> IntList = new List<int>() { 4, 6, 10, 58, 64, 90 };

                Console.WriteLine("Choose a number to divide the list by");
                int divNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < IntList.Count; i++)
                {
                    IntList[i] = IntList[i] / divNum;
                    Console.WriteLine(IntList[i]);
                }

                Console.ReadLine();
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Please write a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
