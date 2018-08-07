﻿using System;
using System.Collections.Generic;
using System.Text;


public class WaterBender : Bender
{
    public double WaterClarity { get; private set; }

    public WaterBender(string name, int power, double waterClarity)
        :base(name, power)
    {
        this.WaterClarity = waterClarity;
    }
}

