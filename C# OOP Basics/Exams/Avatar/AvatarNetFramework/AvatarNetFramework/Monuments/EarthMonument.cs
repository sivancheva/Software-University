using System;
using System.Collections.Generic;
using System.Text;


public class EarthMonument : Monument
{

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.Affinity = earthAffinity;
    }


    public override string ToString()
    {
        return $"###Earth Monument: {this.Name}, Earth Affinity: {this.Affinity}";
    }
}

