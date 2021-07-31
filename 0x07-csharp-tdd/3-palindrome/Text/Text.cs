using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary>Creation of class str</summary>

    public class Str
    {
        ///<summary>search for palindrome</summary>
        ///<param name="s">string of palindrome</param>
        ///<returns>true/false</returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return true;
            }
            ///<summary>convert to lower case and removing punctuation </summary>
            s = s.ToLower();
            s = Regex.Replace(s, "[:;.,'<>/?!@#$%^&*(){} ]", "");
            char[] revS = s.ToCharArray();
            Array.Reverse(revS);
            ///<summary>check if s is the same with revS</summary>
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != revS[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}