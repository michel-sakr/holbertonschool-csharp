using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> set = new HashSet<int>(myList);
        int sum = 0;
        foreach (int element in set)
        {
            sum += element;
        }
        return sum;
    }
}