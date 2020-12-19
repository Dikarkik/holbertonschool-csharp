using System;

/// <summary>
/// This class defines operations for inheritance checking
/// </summary>
class Obj
{
    /// <summary>
    /// method that checks if 'obj' is a subclass of 'baseType'
    /// <param name="obj">object to check</param>
    /// <returns>True if 'derivedType' inherits from 'baseType', otherwise return False</returns>
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;

        return false;
    }
}
