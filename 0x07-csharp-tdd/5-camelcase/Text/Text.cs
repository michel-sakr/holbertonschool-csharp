using System;

namespace Text
{
    ///<summary>Creation of class Str</summary>
    public class Str
    {
        ///<summary>find number of words</summary>
        ///<param name="s"> string of words</param>
        ///<returns>number of words</returns>
        public static int CamelCase(string s)
        {
            int count = 1;
            if (s == null || s == "")
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsUpper(s[i]) == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}