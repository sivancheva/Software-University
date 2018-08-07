using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int engineCount = int.Parse(Console.ReadLine());

        var engines = new Dictionary<string, Engine>();
        var cars = new List<Car>();

        for (int i = 0; i < engineCount; i++)
        {
            //<Model> <Power> <Displacement> <Efficiency>
            var input = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
            var model = input[0];
            var power = input[1];
            var engineToAdd = new Engine(model, power);

            if (input.Length == 4)
            {
                engineToAdd.Displacement = input[2];
                engineToAdd.Efficiency = input[3];
            }
            else if (input.Length == 3)
            {
                //check if Displacement or Efficiency
                var charOrDigit = input[2][0];
                if (char.IsDigit(charOrDigit))
                {
                    engineToAdd.Displacement = input[2];
                }
                else
                {
                    engineToAdd.Efficiency = input[2];
                }
            }
            engines.Add(model, engineToAdd);
        }

        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            //“<Model> <Engine> <Weight> <Color>
            var carModel = input[0];
            var engineToAdd = engines[input[1]];
            var carToAdd = new Car(carModel, engineToAdd);

            if (input.Length == 4 )
            {
                carToAdd.Weight = input[2];
                carToAdd.Color = input[3];
            }
            else if (input.Length == 3)
            {
                //check if Weight or Color
                var charOrDigit = input[2][0];
                if (char.IsDigit(charOrDigit))
                {
                    carToAdd.Weight = input[2];
                }
                else
                {
                    carToAdd.Color = input[2];
                }
            }
            cars.Add(carToAdd);
        }

        foreach (var car in cars)
        {
            PrintCarInformation(car);
        }
      
    }

    private static void PrintCarInformation(Car car)
    {
        Console.WriteLine($"{car.Model}:");
        Console.WriteLine($"  {car.Engine.Model}:");
        Console.WriteLine($"    Power: {car.Engine.Power}");
        Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
        Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
        Console.WriteLine($"  Weight: {car.Weight}");
        Console.WriteLine($"  Color: {car.Color}");
    }
}



