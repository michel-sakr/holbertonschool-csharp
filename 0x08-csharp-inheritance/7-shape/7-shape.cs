using System;

class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
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
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Method that returns the area of a rectangle
    /// </summary>
    /// <returns>width times height</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Tostring
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}