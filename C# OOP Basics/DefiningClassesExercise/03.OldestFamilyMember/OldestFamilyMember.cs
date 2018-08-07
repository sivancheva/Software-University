using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


class OldestFamilyMember
{
    static void Main(string[] args)
    {
               
        int n = int.Parse(Console.ReadLine());

        var members = new Family();

        for (int i = 0; i < n; i++)
        {
            var inputArr = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
            var name = inputArr[0];
            var age = int.Parse(inputArr[1]);

            var currentMember = new Person();
            currentMember.Name = name;
            currentMember.Age = age;
            members.AddMember(currentMember);

        }

        var oldest = members.GetOldestMember();

        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}

