using System;
using System.Collections.Generic;
using System.Text;


public class HardTyre : Tyre
{
    protected override string Name => "Hard";

    public HardTyre(double hardnes):
        base(hardnes)   { }

}

