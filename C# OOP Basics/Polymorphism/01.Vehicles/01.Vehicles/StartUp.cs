using System;

public class StartUp
{
    static void Main(string[] args)
    {

        var carInput = Console.ReadLine().Split();
        var truckInput = Console.ReadLine().Split();
        var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
        var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var commands = Console.ReadLine().Split();
            var action = commands[0];
            var vehicleType = commands[1];

            switch(vehicleType)
            {
                case "Car":
                    switch(action)
                    {
                        case "Drive": car.Drive(double.Parse(commands[2]));
                            break;
                        case "Refuel": car.Refuel(double.Parse(commands[2]));
                            break;
                    }
                    break;

                case "Truck":
                    switch (action)
                    {
                        case "Drive":
                            truck.Drive(double.Parse(commands[2]));
                            break;
                        case "Refuel":
                            truck.Refuel(double.Parse(commands[2]));
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
    }
}

