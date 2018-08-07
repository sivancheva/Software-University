using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    private double quantity;

    public Food(double quantity)
    {
        this.Quantity = quantity;
    }

    public double Quantity
    {
        get { return quantity; }
        protected set { quantity = value; }
    }

}

