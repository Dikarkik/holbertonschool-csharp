using System;

/// <summary>
/// This class defines a Shape
/// </summary>
public class Shape
{
    /// <summary>
    /// method that Throws an NotImplementedException
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
