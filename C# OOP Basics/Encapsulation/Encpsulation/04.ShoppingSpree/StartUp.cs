using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var people = new List<Person>();
        var products = new List<Product>();


        var peopleInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var productInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int i = 0; i < peopleInput.Length; i+=2)
        {
            var name = peopleInput[i];
            var money = decimal.Parse(peopleInput[i+1]);
            var personToAdd = new Person(name, money);
            people.Add(personToAdd);
        }

        for (int i = 0; i < productInput.Length; i+=2)
        {
            var name = productInput[i];
            var cost = decimal.Parse(productInput[i+1]);
            var productToAdd = new Product(name, cost);
            products.Add(productToAdd);
        }

        string command = Console.ReadLine();
        while (command.ToLower()  != "end")
        {

            var input = command.Split();
            var namePerson = products.FirstOrDefault(p => p.Name == input[1]);          

            var productToBuy = products.Where(x => x.Name == input[1]);

            

            command = Console.ReadLine();
        }
    }
}

