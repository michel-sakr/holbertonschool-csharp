using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string key = String.Empty;
        int value = 0;
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value >= value)
            {
                value = kvp.Value;
                key = kvp.Key;
            }
        }
        return key;
    }
}