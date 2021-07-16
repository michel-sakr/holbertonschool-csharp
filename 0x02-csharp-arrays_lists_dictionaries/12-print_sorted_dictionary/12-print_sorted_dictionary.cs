using System;
using System.Collections.Generic;


class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> key = new List<string>(myDict.Keys);
        key.Sort();
        for (int i = 0; i < myDict.Count; i++)
        {
            Console.WriteLine("{0}: {1}", key[i], myDict[key[i]]);
        }
    }
}