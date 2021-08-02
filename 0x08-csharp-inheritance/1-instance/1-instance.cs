using System;
using System.Collections.Generic;

namespace _1_instance
{
    class Obj
    {
        /// <summary>
        /// Method that returns true is and object is an instance of array
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool IsInstanceOfArray(object obj)
        {
            if (obj is Array)
            {
                return true;
            }
            return false;
        }
    }
}
