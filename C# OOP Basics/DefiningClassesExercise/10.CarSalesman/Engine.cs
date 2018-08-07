﻿using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public Engine(string model, string power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }
    public Engine(string model, string power, string displacement, string efficiency):this(model, power)
    {
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Power
    {
        get { return power; }
        set { power = value; }
    }
    public string Displacement
    {
        get { return displacement; }
        set { displacement = value; }
    }
    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }



}

