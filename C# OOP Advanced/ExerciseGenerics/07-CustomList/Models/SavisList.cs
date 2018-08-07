using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ISavisList<T>, IEnumerable<T>
    where T : IComparable
{
    private const int InitialLength = 4;
    private T[] data;
    private int DataSize { get; set; }
    private int Count { get; set; }

    public CustomList()
    {
        this.data = new T[InitialLength];
        this.Count = 0;
        this.DataSize = InitialLength;
    }

    public void Add(T element)
    {
        if (this.Count == this.DataSize)
        {
            int newDataSize = this.DataSize * 2;
            var dataExtended = new T[newDataSize];
            Array.Copy(data, dataExtended, this.Count);
            this.data = dataExtended;
            this.DataSize = newDataSize;
        }
        this.data[this.Count] = element;
        this.Count++;
    }

    public bool Contains(T element)
    {
        bool result = false;
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].Equals(element))
            {
                result = true;
                break;
            }
        }
        return result;
    }

    public int CountGreaterThan(T element)
    {
        int counter = 0;
        for (int i = 0; i < this.Count; i++)
        {
            if (this.data[i].CompareTo(element) == 1)
            {
                counter++;
            }
        }
        return counter;
    }

    public T Max()
    {

        if (this.Count == 0)
        {
            throw new ArgumentException("Collection is empty!");
        }
        else
        {
            var maxElement = this.data[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (maxElement.CompareTo(this.data[i]) < 1)
                {
                    maxElement = this.data[i];
                }
            }

            return maxElement;
        }
    }

    public T Min()
    {
        if (this.Count == 0)
        {
            throw new ArgumentException("Collection is empty!");
        }
        else
        {
            var minElement = this.data[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (minElement.CompareTo(this.data[i]) > 1)
                {
                    minElement = this.data[i];
                }
            }

            return minElement;


        }

    }

    public T Remove(int index)
    {

        if (this.Count > 0 && index < this.DataSize)
        {
            T element = this.data[index];

            for (int i = index; i < this.Count; i++)
            {
                this.data[index] = this.data[index + 1];
            }

            this.data[this.Count] = default(T);
            this.Count--;
            return element;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    public void Swap(int index1, int index2)
    {
        if ((index1 >= 0 && index1 < this.Count) && (index2 >= 0 && index2 < this.Count))
        {
            var currElement = this.data[index2];
            this.data[index2] = this.data[index1];
            this.data[index1] = currElement;
        }
        else
        {
            throw new IndexOutOfRangeException();
        }

    }

    public void Print()
    {
        for (int i = 0; i < this.Count; i++)
        {
            Console.WriteLine(this.data[i]);
        }
    }

    public void Sort()
    {
        this.data = this.data
                    .Where(x => x != null)
                    .OrderBy(x => x)
                    .ToArray();
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            yield return this.data[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

