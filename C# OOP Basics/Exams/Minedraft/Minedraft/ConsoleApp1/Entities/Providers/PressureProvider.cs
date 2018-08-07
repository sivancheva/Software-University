using System;
using System.Collections.Generic;
using System.Text;


public class PressureProvider : Provider
{

    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput) { }


    public override double EnergyOutput { get => base.EnergyOutput + base.EnergyOutput * 0.5; }
}

