using System;
using System.Collections.Generic;
using System.Text;


public class Person : IComparable<Person>
{
    public string Name { get; }
    public int Age { get; }
    public string Town { get;}

    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }
    

    public int CompareTo(Person other)
    {
        var comparision = this.Name.CompareTo(other.Name);
        if (comparision != 0)
        {
            return comparision;
        }

        comparision = this.Age.CompareTo(other.Age);
        if (comparision != 0)
        {
            return comparision;
        }

        return this.Town.CompareTo(other.Town);
    }
}

