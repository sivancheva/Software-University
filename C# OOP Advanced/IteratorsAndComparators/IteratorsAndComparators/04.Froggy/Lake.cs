using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Lake<T> : IEnumerable<T>
{
    public List<T> StoneList { get; private set; }

    public Lake(IEnumerable<T> elementsToAdd)
    {       
        this.StoneList = new List<T>(elementsToAdd);
        var evenPositions = this.StoneList.Where((c, i) => i % 2 == 0).ToList();
        var oddPositions = this.StoneList.Where((c, i) => i % 2 != 0).Reverse().ToList();
        var froggysPattern = new List<T>();
        froggysPattern.AddRange(evenPositions);
        froggysPattern.AddRange(oddPositions);
        Console.WriteLine(String.Join(", ", froggysPattern));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.StoneList.Count; i++)
        {
            yield return this.StoneList[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.StoneList.GetEnumerator();
    }
}

