using System;

/// <summary>
/// Class rectangle that inherits from class Shape
/// </summary>
class Rectangle : Shape
{

    /// <summary>
    /// Declaration of variables
    /// </summary>
    private int width; //width
    private int height; //height
    public int Width
    {
        /// <summary>
        /// Property width
        /// </summary>
        /// <value>input</value>
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        /// <summary>
        /// Property height
        /// </summary>
        /// <value>input</value>
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
class Shape
{
    /// <summary>
    /// Method that returns exception
    /// </summary>
    /// <returns>exception</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}