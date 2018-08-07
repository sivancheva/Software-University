using GenericBox;
using System;
using System.Collections.Generic;

public static class Solutions
{
    
    public static void SwapMethodIntegers(List<Box<int>> listOfIntegers)
    {
        var input = Console.ReadLine().Split();
        var firstIndex = int.Parse(input[0]);
        var secondIndex = int.Parse(input[1]);

        var currElement = listOfIntegers[secondIndex];
        listOfIntegers[secondIndex] = listOfIntegers[firstIndex];
        listOfIntegers[firstIndex] = currElement;
    }
}

