using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// Class object with method
    /// </summary>
    /// <param name="obj">input</param>
    /// <returns>if obj is int returns true</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        return false;
    }
}

