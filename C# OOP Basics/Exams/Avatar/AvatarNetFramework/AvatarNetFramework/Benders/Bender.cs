using System;
using System.Collections.Generic;
using System.Text;


public abstract class Bender
{
    public string Name { get; }
    public int Power { get; private set; }
    public virtual double TotalPower { get; private set; }


    protected Bender(string name, int power)
    {
        Name = name;
        Power = power;
    }
}

