using System;
using System.Collections.Generic;
using System.Text;


public class EarthMonument : Monument
{
    public int EarthAffinity { get; private set; }

    public EarthMonument(string name, int earthAffinity)
        :base(name)
    {
        EarthAffinity = earthAffinity;
    }
       
}

