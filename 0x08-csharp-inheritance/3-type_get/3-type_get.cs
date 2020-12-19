using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>
/// This class defines operations about type information
/// </summary>
class Obj
{
    /// <summary>
    /// method that prints the names of the available properties and methods of an object
    /// <param name="myObj">object to check</param>
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        // print properties
        Console.WriteLine($"{myObj.GetType().Name} Properties:");

        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }

        // print methods
        Console.WriteLine($"{myObj.GetType().Name} Methods:");

        foreach (MethodInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}
