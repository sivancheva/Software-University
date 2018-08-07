using System;
using System.Collections.Generic;
using System.Linq;


public class SpeedRacing
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var model = input[0];
            var fuelAmount = decimal.Parse(input[1]);
            var fuelConsumption = decimal.Parse(input[2]);

            var carCurrent = new Car();
            carCurrent.Model = model;
            carCurrent.FuelAmount = fuelAmount;
            carCurrent.FuelConsumption = fuelConsumption;

            cars.Add(carCurrent);
        }

        var command = Console.ReadLine();

        while (command != "End")
        {
            var commandArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var modelToDrive = commandArr[1];
            var kmToDrive = decimal.Parse(commandArr[2]);
            Car carToDrive = cars.Where(c => c.Model == modelToDrive).First();

            carToDrive.DriveCar(kmToDrive);

            command = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
        }
    }
}

