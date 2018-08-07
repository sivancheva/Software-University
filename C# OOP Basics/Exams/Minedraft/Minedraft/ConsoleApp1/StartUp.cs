using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {

        string input;
        DraftManager draftManager = new DraftManager(); //inicialisirame nov Draftmanager;

        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var commandArgs = input.Split().ToList();
            var command = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(commandArgs)); // izvikvame novosuzdadenija po-gore draftmanger i mu podavame komandi
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(commandArgs));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(commandArgs));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(commandArgs));
                    break;
            }
        }
        Console.WriteLine(draftManager.ShutDown());
    }
}

