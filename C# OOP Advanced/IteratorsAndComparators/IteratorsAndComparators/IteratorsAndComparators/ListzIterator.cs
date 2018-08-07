using System;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T>
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

}

