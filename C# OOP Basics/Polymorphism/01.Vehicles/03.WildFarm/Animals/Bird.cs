using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bird : Animal
{

    protected double wingSize;

    public Bird(string name, double weight, double wingSize)
        :base(name, weight)
    {
       this. WingSize = wingSize;
    }

    protected double WingSize
    {
        get { return wingSize; }
        set { wingSize = value; }
    }


    public override string ToString()
    {
        return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }

   

}

