﻿using System;
using System.Collections.Generic;
using System.Text;


public class Citizen:IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    private string name;
    private int age;
    private string id;
    private string birthdate;


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


}

