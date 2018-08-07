using System;
using System.Collections.Generic;
using System.Text;


public class Hen : Bird
{
    private const double weightFactor = 0.35;
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }

    public override void Eat(Food food)
    {
        this.Weight += food.Quantity * weightFactor;
        this.FoodEaten += food.Quantity;
    }
}

