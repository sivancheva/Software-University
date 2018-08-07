using System;
using System.Collections.Generic;
using System.Text;


public class UltrasoftTyre : Tyre
{

    private double grip;
    private double degradation;
    protected override string Name => "Ultrasoft";

    public UltrasoftTyre(double hardness, double grip)
        :base(hardness)

    {
        this.Grip = grip;
    }

    public double Grip
    {
        get { return grip; }
        set { grip = value; }
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
        this.Degradation -= (base.Degradation + this.Grip);
    }


}

