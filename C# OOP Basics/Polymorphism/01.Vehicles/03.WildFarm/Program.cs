using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {

        var animals = new List<Animal>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            Animal animal = null;
            animal = GetAnimal(input, animal);
            animals.Add(animal);
            Food food = null;
            food = GetFood(food);

            animal.ProduceSound();
            try
            {
                animal.Eat(food);
            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
            }

        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static Food GetFood(Food food)
    {
        var foodInput = Console.ReadLine().Split();
        var foodType = foodInput[0];
        var foodQuantity = double.Parse(foodInput[1]);

        switch (foodType)
        {
            case "Vegetable":
                var vegetable = new Vegetable(foodQuantity);
                food = vegetable;
                break;

            case "Fruit":
                var fruit = new Fruit(foodQuantity);
                food = fruit;
                break;

            case "Meat":
                var meat = new Meat(foodQuantity);
                food = meat;
                break;
            case "Seeds":
                var seeds = new Seeds(foodQuantity);
                food = seeds;
                break;
            default:
                break;
        }

        return food;
    }

    private static Animal GetAnimal(string input, Animal animal)
    {
        var animalInput = input.Split();

        var animalType = animalInput[0];
        var animalName = animalInput[1];
        var animalWeight = double.Parse(animalInput[2]);

        switch (animalType)
        {

            case "Cat":
                var cat = new Cat(animalName, animalWeight, animalInput[3], animalInput[4]);
                animal = cat;
                break;
            case "Tiger":
                var tiger = new Tiger(animalName, animalWeight, animalInput[3], animalInput[4]);
                animal = tiger;
                break;
            case "Owl":
                var owl = new Owl(animalName, animalWeight, double.Parse(animalInput[3]));
                animal = owl;
                break;
            case "Hen":
                var hen = new Hen(animalName, animalWeight, double.Parse(animalInput[3]));
                animal = hen;
                break;
            case "Mouse":
                var mouse = new Mouse(animalName, animalWeight, animalInput[3]);
                animal = mouse;
                break;
            case "Dog":
                var dog = new Dog(animalName, animalWeight, animalInput[3]);
                animal = dog;
                break;

            default:
                break;
        }

        return animal;
    }
}

