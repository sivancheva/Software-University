using System;
using System.Collections.Generic;
using System.Text;

public class FireMonument : Monument
{


    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.Affinity = fireAffinity;
    }

    public override string ToString()
    {
        return $"###Fire Monument: {this.Name}, Fire Affinity: {this.Affinity}";
    }
}