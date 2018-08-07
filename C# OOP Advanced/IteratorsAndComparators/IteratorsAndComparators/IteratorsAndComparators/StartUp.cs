using System;
using System.Linq;


public class StartUp
{
    static void Main(string[] args)
    {
        var currentList = new ListyIterator<string>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var commandArgs = input.Split().ToList();
            var command = commandArgs[0];
            switch (command)
            {
                case "Create":
                    var listArgs = commandArgs.Skip(1).ToList();
                    currentList.Create(listArgs);
                    break;
                case "HasNext":
                    Console.WriteLine(currentList.HasNext());
                    break;
                case "Move":
                    Console.WriteLine(currentList.Move());
                    break;
                case "Print":
                    currentList.Print();
                    break;

            }
        }
    }
}

