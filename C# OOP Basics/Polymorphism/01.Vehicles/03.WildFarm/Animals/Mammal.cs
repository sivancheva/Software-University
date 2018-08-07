using System;
using System.Collections.Generic;
using System.Text;

public abstract class Mammal: Animal
{

    private string livingRegion;

    public Mammal(string name, double weigth, string livingRegion)
        :base(name, weigth)
    {
        this.LivingRegion = livingRegion;
    }

    protected string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public override string ToString()
    { 
        return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

