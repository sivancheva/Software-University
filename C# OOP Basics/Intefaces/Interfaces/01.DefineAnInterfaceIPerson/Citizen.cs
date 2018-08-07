﻿using System;
using System.Collections.Generic;
using System.Text;


public class Citizen:IPerson
{
    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    private string name;
    private int age;


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


}

