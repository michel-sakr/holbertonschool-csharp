using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string,int> dic = new Dictionary<string, int>(myDict);
        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            dic[kvp.Key] = kvp.Value * 2;
        }
        return dic;
    }
}