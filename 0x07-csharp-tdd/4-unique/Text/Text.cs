using System;

namespace Text
{
    ///<summary>Creation of class str</summary>
    public class Str
    {
        ///<summary>find first non repeating</summary>
        ///<param name="s">string of char</param>
        ///<returns>index or -1 if no unique char</returns>
        public static int UniqueChar(string s)
        {
            int count;
            char[] x = s.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                count = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == x[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
