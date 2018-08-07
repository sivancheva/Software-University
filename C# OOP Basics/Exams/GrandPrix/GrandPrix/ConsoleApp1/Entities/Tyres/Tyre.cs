﻿using System;
using System.Collections.Generic;
using System.Text;


 public abstract class Tyre
    {
   
    public abstract string Name { get;  }
    public double Hardness { get; private set; }
    private double degradation;

    protected Tyre(double hardness)
    {    
        this.Hardness = hardness;
        this.Degradation = 100;
    }

    public virtual double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}

