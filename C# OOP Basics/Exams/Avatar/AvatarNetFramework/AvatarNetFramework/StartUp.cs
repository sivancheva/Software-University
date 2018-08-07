using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    static void Main(string[] args)
    {
        NationsBuilder nations = new NationsBuilder();
        string input;
        
        while ((input = Console.ReadLine()) != "Quit")
        {
            var inputArgs = input.Split().ToList();
            var command = inputArgs[0];
            inputArgs.RemoveAt(0);

            switch (command)
            {
                case "Bender":
                    nations.AssignBender(inputArgs);
                    break;
                case "Monument":
                    nations.AssignMonument(inputArgs);
                    break;
                case "War":
                    nations.IssueWar(inputArgs[0]);
                    break;
                case "Status":
                    Console.WriteLine(nations.GetStatus(inputArgs[0])); 
                    break;
            }
        }
        Console.WriteLine(nations.GetWarsRecord());
               
    }
}

