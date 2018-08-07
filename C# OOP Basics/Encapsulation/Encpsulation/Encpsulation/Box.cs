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
        set
        {
            
            length = value;
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            
            width = value;
        }
    }


    public double Height
    {
        get { return height; }
        set
        {
            
            this.height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double GetSurfaceArea(double length, double width, double height)
    {
        //2lw + 2lh + 2wh
        return (2*((length*width) + (length*height) +(width*height)));
    }
    public double GetLateralSurfaceArea (double length, double width, double height)
    {
        //2lh + 2wh
        return (2*((length*height) + (width*height)));
    }

    public double GetVolume(double length, double width, double height)
    {
        return (length*width*height);

    }


    public override string ToString()
    {
        var result = new StringBuilder();
        var surfaceArea = GetSurfaceArea(this.length, this.width, this.height);
        var lateralArea = GetLateralSurfaceArea(this.length, this.width, this.height);
        var volume = GetVolume(this.length, this.width, this.height);
        result.AppendLine($"Surface Area - {surfaceArea:f2}");
        result.AppendLine($"Lateral Surface Area - {lateralArea:f2}");
        result.AppendLine($"Volume - {volume:f2}");
        return result.ToString();
    }

}

