using System;
using System.Collections.Generic;
using System.Text;


public class UltrasoftTyre : Tyre
{
    public override string Name => "Ultrasoft";
    private double grip;
    private double degradation;

    public UltrasoftTyre( double hardness, double grip)
        :base(hardness)
    {
        this.Grip = grip;
    }


    public double Grip
    {
        get { return grip; }
        protected set
        {
            grip = value;
        }
    }

    public override double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (value < 30)
            {
                throw new ArgumentException("Blown Tyre");
            }
            degradation = value;
        }
    }
    



    public override void ReduceDegradation()
    {
        this.Degradation -= this.Hardness + this.Degradation;
    }
}

