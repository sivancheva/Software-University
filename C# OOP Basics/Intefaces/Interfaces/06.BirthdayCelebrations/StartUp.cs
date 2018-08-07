using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)

    {
        var result = new List<IBirthable>();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var inputArr = input.Split();

            switch (inputArr[0].ToLower())
            {
                case "citizen":
                    var citizen = new Citizen(inputArr[1], int.Parse(inputArr[2]), inputArr[3], inputArr[4]);
                    result.Add(citizen);
                    break;
                case "pet":
                    var pet = new Pet(inputArr[1], inputArr[2]);
                    result.Add(pet);
                    break;
                case "robot":
                    break;
                default:
                    break;
            }
        }

        string searchedYear = Console.ReadLine();

        foreach (var item in result)
        {
            if (item.Birthdate.EndsWith(searchedYear))
            {
                Console.WriteLine(item.Birthdate);
            }
        }
    }


}

