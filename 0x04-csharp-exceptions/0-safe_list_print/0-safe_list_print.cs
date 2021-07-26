using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int element = 0;
        try
        {
            while (element < n)
            {
                Console.WriteLine(myList[element]);
                element++;
            }
        }
        catch
        {
        }
        return element;

    }
}