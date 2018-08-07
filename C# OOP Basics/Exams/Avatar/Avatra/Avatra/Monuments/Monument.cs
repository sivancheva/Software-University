using System;
using System.Collections.Generic;
using System.Text;


public abstract class Monument
{   

    public string Name { get; }

    protected Monument(string name)
    {
        Name = name;
    }
}

