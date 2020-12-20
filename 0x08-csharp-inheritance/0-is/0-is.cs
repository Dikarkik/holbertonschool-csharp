/// <summary>
/// This class defines operations for type checking
/// </summary>
public class Obj
{
    /// <summary>
    /// method that checks if an object is type int
    /// <param name="obj">object to check</param>
    /// <returns>True if 'obj' is an int, otherwise return False</returns>
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
