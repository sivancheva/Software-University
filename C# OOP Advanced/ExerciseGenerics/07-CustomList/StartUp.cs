﻿using System;

namespace _07_CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {               
                var commandArgs = input.Split();
                var command = commandArgs[0];

                switch (command)
                {
                    case "Add":
                        customList.Add(commandArgs[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(commandArgs[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(commandArgs[1])); 
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(commandArgs[1])); 
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max()); 
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min()); 
                        break;
                    case "Sort":
                        customList.Sort();
                        break;
                    case "Print":
                        customList.Print(); 
                        break;
                    
                }
            }
        }
    }
}
