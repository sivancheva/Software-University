using System;
using System.Collections.Generic;
using System.Linq;

public class OpinionPoll
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var listPeople = new List<Person>();
        

        for (int i = 0; i < n; i++)
        {
            var inputArr = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

            var name = inputArr[0];
            var age = int.Parse(inputArr[1]);

            var currPerson = new Person();
            currPerson.Age = age;
            currPerson.Name = name;
            listPeople.Add(currPerson);          
        }

        var orderedList = new List<Person>(listPeople);

        foreach (var person in orderedList.Where(p => p.Age >30).OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

    }
}

