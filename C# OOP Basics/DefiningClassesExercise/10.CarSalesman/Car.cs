using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    //model, engine, weight and color

    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = "n/a";
    }

    public Car(string model, Engine engine, string weight, string color):this(model, engine)
    { 
        this.weight = weight;
        this.color = color;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

}

