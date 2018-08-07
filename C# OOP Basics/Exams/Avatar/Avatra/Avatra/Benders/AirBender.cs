using System;
using System.Collections.Generic;
using System.Text;


public class AirBender : Bender
{
    public double  AerialIntegrity  { get; private set; }

    public AirBender(string name, int power, double aerialIntegrity)
        :base(name, power)
    {
        this.AerialIntegrity = AerialIntegrity;
    }
}

