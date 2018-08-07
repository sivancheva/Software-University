using System;
using System.Collections.Generic;
using System.Text;


public class AirMonument : Monument
{
    
    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.Affinity = airAffinity;
    }

    public override string ToString()
    {
        return $"###Air Monument: {this.Name}, Air Affinity: {this.Affinity}";
    }
}

