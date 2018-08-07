using System;
using System.Collections.Generic;
using System.Text;


public class Person
{

    private const int MinAge = 0;
    
    public const int MinNameLength = 3;
    private int age;
    private string name;

    public Person( string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        protected set
        {
            if (value.Length < MinNameLength)
            {
                throw new ArgumentException($"Name's length should not be less than {MinNameLength} symbols!");
            }
            name = value;
        }
    }

    public virtual int Age
    {
        get { return this.age; }
        protected set
        {
            if (value < MinAge )
            {
                throw new ArgumentException("Age must be positive!");
            }
            age = value;
        }
    }

    public override string ToString()
    {
        return $"Name: {this.Name}, Age: {this.Age}";
    }

}

