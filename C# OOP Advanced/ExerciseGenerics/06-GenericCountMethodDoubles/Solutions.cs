﻿using GenericBox;
using System;
using System.Collections.Generic;

public static class Solutions
{
    
    public static int CountStrings(List<Box<double>> listOfStrings, Box<double> comparerValue )
    {
        int counter = 0;

        foreach (var item in listOfStrings)
        {
            if (item.CompareTo(comparerValue) == 1)
            {
                counter++;
            }

        }      

        return counter;
    }
}
