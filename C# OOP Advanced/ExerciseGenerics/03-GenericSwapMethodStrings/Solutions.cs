using GenericBox;
using System;
using System.Collections.Generic;

public static class Solutions
{
    public static void SwapMethodStrings(List<Box<string>> listOfStrings)
    {
        var input = Console.ReadLine().Split();
        var firstIndex = int.Parse(input[0]);
        var secondIndex = int.Parse(input[1]);

        var currElement = listOfStrings[secondIndex];
        listOfStrings[secondIndex] = listOfStrings[firstIndex];
        listOfStrings[firstIndex] = currElement;
    }
    

   
}

