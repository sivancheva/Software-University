using System;
using System.Collections.Generic;
using System.Text;


public class AirBender : Bender
{
    public double AerialIntegrity { get; private set; }
    public  override double TotalPower  => this.Power * this.AerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override string ToString()
    {
        return $"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}

