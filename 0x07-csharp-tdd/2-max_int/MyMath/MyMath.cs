using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Creation of class Operations</summary>

    public class Operations
    {
        ///<param name="nums">new int list</param>
        ///<returns>max int in list</returns>
        ///<summary>Method check if 0 or sort</summary>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            else
            {
                nums.Sort();
                return nums[nums.Count - 1];
            }
        }
    }
}
