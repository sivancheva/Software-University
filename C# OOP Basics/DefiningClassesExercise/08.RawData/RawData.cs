using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            
            var model = input[0];
            var engineSpeed = int.Parse(input[1]);
            var enginePower = int.Parse(input[2]);
            var cargoWeight = int.Parse(input[3]);
            var cargoType = input[4];
            

            var currEngine = new Engine(engineSpeed,enginePower);
            var currCargo = new Cargo(cargoWeight, cargoType);
            var currTires = new Tire[4];

            int counter = 0;
            for (int t = 5; t < 12; t+=2)
            {
                var tirePressure = double.Parse(input[t]);
                var tireAge = int.Parse(input[t+1]);
                var currTire = new Tire(tirePressure, tireAge);

                currTires[counter] = currTire;
                counter++;
            }

            var currCar = new Car(model, currEngine, currCargo, currTires);

            cars.Add(currCar);
        }
        var command = Console.ReadLine();

        if (command == "fragile")
        {
            cars.Where(c => c.Cargo.CargoType == command && c.Tires.Any(t => t.Pressure < 1))
                                .ToList()
                                .ForEach(c => Console.WriteLine($"{c.Model}"));
           
        }
        else if (command == "flamable")
        {
            cars.Where(c => c.Cargo.CargoType == command && c.Engine.EnginePower > 250)
                                .ToList()
                                .ForEach(c => Console.WriteLine($"{c.Model}"));
        }
    }
}

