using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    protected abstract string Name { get; }
    private double hardness;
    private double degradation;

    protected Tyre( double hardness)
    {
       this.hardness = hardness;
       this.degradation = 100;
    }
      

    public double Hardness
    {
        get { return hardness; }
        protected set { hardness = value; }
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

