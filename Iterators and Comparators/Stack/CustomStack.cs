using System;
using System.Collections;
using System.Collections.Generic;

public class CustomStack<T>:IEnumerable<T>
{
    private readonly IList<T> collection;

    public CustomStack()
    {
        this.collection = new List<T>();
    }

    public void Push(params T[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            collection.Add(data[i]);
        }
    }

    public void Pop()
    {
        if (collection.Count==0)
        {
            Console.WriteLine("No elements");
        }
        else
        {
            collection.RemoveAt(collection.Count-1);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < collection.Count; i++)
        {
            yield return collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}