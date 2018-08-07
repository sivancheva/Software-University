using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
    private const double weightFactor = 0.10;
    public Mouse(string name, double weigth, string livingRegion)
        :base(name, weigth, livingRegion) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
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

