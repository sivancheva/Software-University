using System;
using System.Collections.Generic;
using System.Text;

public class WaterMonument : Monument
{

    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.Affinity = waterAffinity;
    }

    public override string ToString()
    {
        return $"###Water Monument: {this.Name}, Water Affinity: {this.Affinity}";
    }
}
