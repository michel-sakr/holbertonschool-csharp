using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int ind = 0;
        LinkedList<int> newLList = new LinkedList<int>(myLList);
        foreach (int element in newLList)
        {
            if (ind == index)
            {
                myLList.Remove(element);
            }
            ind++;
        }
    }
}