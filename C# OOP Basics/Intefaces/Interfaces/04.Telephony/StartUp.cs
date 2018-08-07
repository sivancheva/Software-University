using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var calls = Console.ReadLine();
        var browsedSites = Console.ReadLine();

        var smartPhone = new Smartphone(calls, browsedSites);

        smartPhone.GetCalls(calls);
        smartPhone.GetBrowsedSites(browsedSites);


    }
}

