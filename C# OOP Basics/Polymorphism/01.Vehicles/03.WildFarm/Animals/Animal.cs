using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    private const double weightFactor=  1;
    private string name;
    private double weight;
    private double foodEaten;

    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
    }

    protected string Name { get => name;  set => name = value; }
    protected double Weight { get => weight;  set => weight = value; }
    protected double FoodEaten { get => foodEaten;  set => foodEaten = value; }

    public abstract void ProduceSound();

    public virtual void Eat(Food food)
    {
        this.Weight = food.Quantity * weightFactor;
        this.FoodEaten += food.Quantity;
    }
   
}

