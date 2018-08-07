using System;
using System.Collections.Generic;

public  class StartUp
{
    static void Main(string[] args)
    {
        //<name> <age> <id> <birthdate>” for a Citizen 
        // “<name> <age><group>” for a Rebel

        var dictOfBuyers = new Dictionary<string, IBuyer>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            if (input.Length == 3)
            {
                var group = input[2];
                var rebel = new Rebel(name, age, group);
                dictOfBuyers.Add(name, rebel);
            }
            else if (input.Length == 4)
            {
                var id = input[2];
                var birthdate = input[3];
                var citizen = new Citizen(name, age, id, birthdate);
                dictOfBuyers.Add(name, citizen);
            }
        }

        string buyer;

        while ((buyer = Console.ReadLine()) != "End")
        {

            if (dictOfBuyers.ContainsKey(buyer))
            {
                dictOfBuyers[buyer].BuyFood();
            }
        }

        int food = 0;
        foreach (var item in dictOfBuyers.Values)
        {

            food += item.Food;
        }

        Console.WriteLine(food);
    }
}

//while ((buyerName = Console.ReadLine()) != "End")
//        {
//            foreach (var buyer in listOfBuyers.Where(b => b.Name == buyerName))
//            {
//                buyer.BuyFood();
//            }
//        }

//        var totalAmountOfFood = listOfBuyers.Sum(b => b.Food);
//Console.WriteLine(totalAmountOfFood);