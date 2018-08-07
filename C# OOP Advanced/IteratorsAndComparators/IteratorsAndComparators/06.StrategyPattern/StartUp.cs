using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var nameComparator = new NameComparator();
        SortedSet<Person> setByNames = new SortedSet<Person>(nameComparator);
        var ageComparator = new AgeComparator();
        SortedSet<Person> setByAge = new SortedSet<Person>(ageComparator);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine().Split();
            var name = inputArgs[0];
            var age = int.Parse(inputArgs[1]);

            Person newPerson = new Person(name, age);
            setByNames.Add(newPerson);
            setByAge.Add(newPerson);
        }

        foreach (var item in setByNames)
        {
            Console.WriteLine(item.ToString());
        }

        foreach (var item in setByAge)
        {
            Console.WriteLine(item.ToString());
        }

    }
}

