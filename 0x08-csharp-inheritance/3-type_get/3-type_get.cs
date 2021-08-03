using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary>
    /// Prints the properties and the methods of the class that is associtated with the object
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();

        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo p in t.GetMethods())
        {
            Console.WriteLine(p.Name);
        }
    }
}

