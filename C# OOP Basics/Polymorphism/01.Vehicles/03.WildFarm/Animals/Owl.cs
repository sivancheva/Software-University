using System;
using System.Collections.Generic;
using System.Text;

public class Owl : Bird
{
    private const double weightFactor = 0.25;
    public Owl(string name, double weight, double wingSize)
        :base(name, weight, wingSize) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * weightFactor;
            this.FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
        }
        
    }
}

