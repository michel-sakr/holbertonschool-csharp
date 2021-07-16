using System;
using System.Collections.Generic;


class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys = 0;
        foreach (KeyValuePair<string, string> kvp in myDict)
        {
            keys++;
        }
        return keys;
    }
}