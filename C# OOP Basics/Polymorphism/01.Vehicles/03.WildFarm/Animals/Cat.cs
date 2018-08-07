using System;
using System.Collections.Generic;
using System.Text;


public class Cat : Feline
{
    private const double weightFactor = 0.3;
    public Cat(string name, double weigth, string livingRegion, string breed)
        : base(name, weigth, livingRegion, breed) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
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

