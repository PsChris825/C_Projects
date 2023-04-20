using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class mathOp
{
    public void MathOperation(int num)
    {
        int result = num / 2;

        Console.WriteLine(result);
    }

    public void OutPutParam(int num2, int num3, out int product)
    {
        product = num2 * num3;

        Console.WriteLine(product);
    }

    public int Add(int num4,  int num5) 
    {
        return num4 + num5;
    }

    public double Add(double num4, double num5)
    {
        return num4 + num5;
    }
}