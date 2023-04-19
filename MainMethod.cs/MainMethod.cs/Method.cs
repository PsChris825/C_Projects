using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathOperations
{
    public int PerformOperation(int num)
    {
        // Perform a math operation on the integer input
        int result = num + 10;

        // Return the result as an integer
        return result;
    }

    public int PerformOperation(double num)
    {
        // Perform a different math operation on the decimal input
        int result = (int)(num * 10);

        // Return the result as an integer
        return result;
    }

    public int PerformOperation(string numString)
    {
        // Convert the string input to an integer, if possible
        int num;
        if (int.TryParse(numString, out num))
        {
            // Perform a different math operation on the integer input
            int result = num / 5;

            // Return the result as an integer
            return result;
        }
        else
        {
            // If the string cannot be converted to an integer, return an error code
            return -1;
        }
    }
}