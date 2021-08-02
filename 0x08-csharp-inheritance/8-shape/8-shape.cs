using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();

        aSquare.Size = 10;

        if (typeof(Square).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Square is a subclass of Shape");
        else
            Console.WriteLine("Square is a NOT subclass of Shape");

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}

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

    public new int Area()
    {
        return width * height;
    }

    public override string ToString()
    {
        return "[Rectangle] " + width + " / " + height;
    }
}

/// <summary>
/// Class square that inherits from rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    public int Size
    {
        /// <summary>
        /// Property size
        /// </summary>
        /// <value>input</value>
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Height = value;
            Width = value;
        }
    }
}
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}