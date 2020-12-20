using System;

/// <summary>
/// This class defines operations for inheritance checking
/// </summary>
public class Obj
{
    /// <summary>
    /// method to checks if 'obj' is in the inheritance tree of 'Array'
    /// <param name="obj">object to check</param>
    /// <returns>True if 'obj' is in the inheritance tree of 'Array', otherwise return False</returns>
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
