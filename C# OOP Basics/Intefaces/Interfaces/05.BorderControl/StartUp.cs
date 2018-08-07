using System;
using System.Collections.Generic;


public class StartUp
{
    static void Main(string[] args)

    {
        var result = new List<IIdenticational>();
        string input;

        while ((input = Console.ReadLine().ToLower()) != "end")
        {
            NewMethod(result, input);
        }

        string fakeId = Console.ReadLine();

        foreach (var item in result)
        {
            if (item.Id.EndsWith(fakeId))
            {
                Console.WriteLine(item.Id);
            }
        }
    }

    private static void NewMethod(List<IIdenticational> result, string input)
    {
        var inputArr = input.Split();
        if (inputArr.Length == 3)
        {
            var citizen = new Citizen(inputArr[0], int.Parse(inputArr[1]), inputArr[2]);
            result.Add(citizen);
        }
        else if (inputArr.Length == 2)
        {
            var robot = new Robot(inputArr[0], inputArr[1]);
            result.Add(robot);
        }
    }
}

