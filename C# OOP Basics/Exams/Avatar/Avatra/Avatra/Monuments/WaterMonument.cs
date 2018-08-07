using System;
using System.Collections.Generic;
using System.Text;

public class WaterMonument : Monument
{

    public int WaterAffinity { get; private set; }

    public WaterMonument(string name, int waterAffinity )
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }
}
