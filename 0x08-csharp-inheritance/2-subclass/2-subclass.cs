using System;

class Obj
{
    /// <summary>
    /// Class Object with method
    /// </summary>
    /// <param name="derivedType">subclass</param>
    /// <param name="baseType">base class</param>
    /// <returns>true if derivedType is subclass of basType</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        return false;
    }
}
