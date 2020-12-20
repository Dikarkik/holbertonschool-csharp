using System;

/// <summary>
/// This class defines operations for inheritance checking
/// </summary>
class Obj
{
    /// <summary>
    /// method that checks if 'derivedType' is a subclass of 'baseType'
    /// <param name="derivedType">object to check</param>
    /// <param name="baseType">Type for comparison</param>
    /// <returns>True if 'derivedType' inherits from 'baseType', otherwise return False</returns>
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
