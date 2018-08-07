using System;
using System.Collections.Generic;
using System.Text;


public class Box

// length, width and height
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }



    public double Width
    {
        get { return width ; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }


    public double Height
    {
        get { return height; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Height cannot be zero or negative.");
            height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double GetSurfaceArea(double length, double width, double height)
    {
        //2lw + 2lh + 2wh
        return (2 *length * width + 2*length * height + 2*width * height);
    }
    public double GetLateralSurfaceArea(double length, double width, double height)
    {
        //2lh + 2wh
        return (2 * length * height + 2*width * height);
    }

    public double GetVolume(double length, double width, double height)
    {
        return (length * width * height);

    }


    public override string ToString()
    {
        var result = new StringBuilder();
        var surfaceArea = GetSurfaceArea(this.length, this.width, this.height);
        var lateralArea = GetLateralSurfaceArea(this.length, this.width, this.height);
        var volume = GetVolume(this.length, this.width, this.height);
        result.AppendLine($"Surface Area – {surfaceArea:f2}");
        result.AppendLine($"Lateral Surface Area – {lateralArea:f2}");
        result.AppendLine($"Volume – {volume:f2}");
        return result.ToString();
    }

}

