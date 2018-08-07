using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
            

        int uniquePeople = 0;
        int duplicatePeople = 0;
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var inputArgs = input.Split();
            var name = inputArgs[0];
            var age = int.Parse(inputArgs[1]);
            var town = inputArgs[2];
            var person = new Person(name, age, town);
            people.Add(person);
        }
        int n = int.Parse(Console.ReadLine());

        CheckForEqualPerson(people, ref uniquePeople, ref duplicatePeople, n);

        if (duplicatePeople % 2 != 0 )
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{duplicatePeople} {uniquePeople} {people.Count}");
        }
    }

    private static void CheckForEqualPerson(List<Person> people, ref int uniquePeople, ref int duplicatePeople, int n)
    {
        Person currentPers = people[n - 1];
       
        for (int i = 0; i < people.Count; i++)
        {            
            if (currentPers.CompareTo(people[i]) == 0)
            {
                duplicatePeople++;
            }
            else
            {
                uniquePeople++;
            }          
        }
        
    }
}

