using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline : Mammal
{
    private string breed;

    public Feline(string name, double weigth, string livingRegion, string breed)
        : base(name, weigth, livingRegion)
    {
        this.Breed = breed;
    }
    protected string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public override string ToString()
    {
        return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

}

