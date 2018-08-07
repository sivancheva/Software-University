using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var currStack = new CustomStack<string>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var commandArgs = input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var command = commandArgs[0];
            
            switch(command)
            {
                case "Push":
                    var elemetsToPush = commandArgs.Skip(1).ToList();
                    currStack.Push(elemetsToPush);
                    break;
                case "Pop":
                    currStack.Pop();
                    break;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var item in currStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
