using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
    private const double weightFactor = 1;
    public Tiger(string name, double weigth, string livingRegion, string breed)
        : base(name, weigth, livingRegion, breed) { }

    public override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
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

