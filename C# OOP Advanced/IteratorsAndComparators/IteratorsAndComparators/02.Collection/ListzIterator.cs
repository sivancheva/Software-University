using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T>:IEnumerable<T>
{
    private const int IteratorStartIndex = 0;
    public List<T> MyList { get; private set; }
    public int StartIndexOfIterator { get; private set; }

    public ListyIterator()
    {
        this.MyList = new List<T>();
        this.StartIndexOfIterator = IteratorStartIndex;
    }


    public void Create(List<T> elementsToAdd)
    {
        this.MyList.AddRange(elementsToAdd);
    }

    public bool HasNext()
    {
        bool hasNext = false;
        if (this.StartIndexOfIterator+1 < this.MyList.Count)
        {
            hasNext = true;
        }
        return hasNext;
    }

    public bool Move()
    {
        bool hasNext = false;
        
        if (HasNext())
        {
            hasNext = true;
            this.StartIndexOfIterator++;
        }
       
        return hasNext;
    }

    public void Print()
    {
        if (this.MyList.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine($"{this.MyList[this.StartIndexOfIterator]}");
        }
    }

    public void PrintAll()
    {
       
            Console.WriteLine(String.Join(" ", this.MyList));
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.MyList.Count; i++)
        {
            yield return this.MyList[i];
        }       
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.MyList.GetEnumerator();
    }
}

