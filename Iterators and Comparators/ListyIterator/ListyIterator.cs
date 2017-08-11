using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T>:IEnumerable<T>
{
    private readonly IList<T> data;
    private int currentIndex;

    public ListyIterator(params T[]data)
    {
        this.currentIndex = 0;
        this.data = new List<T>(data);
    }

    public bool Move()
    {
        if (this.currentIndex<this.data.Count-1)
        {
            currentIndex++;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (data.Count>0)
        {
            Console.WriteLine($"{this.data[currentIndex]}");
        }
        else
        {
            Console.WriteLine("Invalid Operation!");
        }
    }

    public bool HasNext()
    {
        if (this.currentIndex<this.data.Count-1)
        {
            return true;
        }
        return false;
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        for (int i = 0; i < data.Count; i++)
        {
            yield return this.data[i];
        }
    }

    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }
}