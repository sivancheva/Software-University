using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private double width;
    private double length;
    private double topLeftx;
    private double topLefty;

    public Rectangle(string id, double width, double length, double xTopLeft, double topLefty)
    {
        this.id = id;
        this.width = width;
        this.length = length;
        this.topLeftx = xTopLeft;
        this.topLefty = topLefty;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public double TopLeftX
    {
        get { return topLeftx; }
        set { topLeftx = value; }
    }

    public double TopLeftY
    {
        get { return topLefty; }
        set { topLefty = value; }
    }

    public static bool Intersect (Rectangle r1, Rectangle r2)
    {
        var r1TopLeftX = r1.TopLeftX;
        var r1TopLeftY = r1.TopLeftY;
        var r1BottomRightX = r1.TopLeftX + r1.length;
        var r1BottomRightY = r1.TopLeftY - r1.width;

        var r2TopLeftX = r2.TopLeftX;
        var r2TopLeftY = r2.TopLeftY;
        var r2BottomRightX = r2.TopLeftX + r2.length;
        var r2BottomRightY = r2.TopLeftY - r2.width;

        
        if ((r1TopLeftX > r2BottomRightX) || (r1BottomRightX < r2TopLeftX) || (r1TopLeftY > r2BottomRightY)  || (r1BottomRightY < r2TopLeftY))
        {
            return false;
        }
        else
        {
            return true;
        }
       
    }
}
