using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari:ICar
{
    private string model;
    private string driver;
       

    public Ferrari(string driverName)
    {
        this.model = "488-Spider";
        this.Driver = driverName;
    }

    public string Model
    {
        get { return model; }
        
    }
    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }

    public virtual string Start()
    {
        return "Zadu6avam sA!";
    }

    public virtual string Stop()
    {
        return "Brakes!";
    }


    public override string ToString()
    {

        return $"488-Spider/Brakes!/Zadu6avam sA!/{this.driver}";
    }

}

