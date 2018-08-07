using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var driversName = Console.ReadLine();
        ICar ferari = new Ferrari(driversName);

        Console.WriteLine(ferari.ToString());

    }
}

