using System;


public class Program
{
    static void Main(string[] args)
    {
        var firstDate = Console.ReadLine();
        var secondaDate = Console.ReadLine();

        var result = DateModifier.GetDaysBetweenDates(firstDate, secondaDate);
        Console.WriteLine(result);
    }
}

