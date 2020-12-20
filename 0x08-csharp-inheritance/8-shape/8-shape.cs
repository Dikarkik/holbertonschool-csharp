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

/// <summary>
/// This class defines a Rectangle
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Property for width
    /// </summary>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }

    /// <summary>
    /// Property for height
    /// </summary>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

    /// <summary>
    /// Method that returns the area of the object
    /// </summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Method that returns the string representation
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}


/// <summary>
/// This class defines a Square
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Property for size
    /// </summary>
    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            else
            {
                size = value;
                this.Height = size;
                this.Width = size;
            }
        }
    }
}
