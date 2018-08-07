using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Mammal
{

    private const double weightFactor = 0.4;
    public Dog(string name, double weigth, string livingRegion)
        : base(name, weigth, livingRegion) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
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

