using System;
using System.Collections.Generic;
using System.Text;


public abstract class Monument
{

    public string Name { get; }
    public virtual int Affinity { get; protected set; }

    protected Monument(string name)
    {
        Name = name;
        Affinity = 0;
    }
}

