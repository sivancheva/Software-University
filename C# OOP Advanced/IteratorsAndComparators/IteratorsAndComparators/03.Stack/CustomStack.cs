using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class CustomStack<T> : IEnumerable<T>
{
    public Stack<T> GenerickStack{ get; private set; }

    public CustomStack()
    {
        this.GenerickStack = new Stack<T>();
    }

    public void Push(List<T> elementsToAdd)
    {
        for (int i = 0; i < elementsToAdd.Count; i++)
        {
            this.GenerickStack.Push(elementsToAdd[i]);
        }      
    }

    public void Pop()
    {
        if (this.GenerickStack.Count > 0)
        {
            this.GenerickStack.Pop();
        }
        else
        {
            Console.WriteLine("No elements");
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        var tempList = new List<T>(this.GenerickStack);
      
        for (int i = 0; i < this.GenerickStack.Count; i++)
        {
            yield return tempList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GenerickStack.GetEnumerator();
    }
}

