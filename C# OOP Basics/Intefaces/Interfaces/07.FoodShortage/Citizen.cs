using System;
using System.Collections.Generic;
using System.Text;


public class Citizen:  IBirthable, IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public void BuyFood()
    {
        this.Food += 10;
    }

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.food = 0;
    }
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }


    public int Food
    {
        get { return food; }
        set { food = value; }
    }
}

