using System;

class Int
{
    public static void divide(int a, int b)
    {
        int div = 0;
        try
        {
            div = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally { Console.WriteLine("{0} / {1} = {2}", a, b, div); }
    }
}