using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class CustomList<T>:IEnumerable<T>
    
{
    private readonly IList<T> data;

    public CustomList()
    {
        this.data=new List<T>();
    }

    private T element { get;  }

    public IList<T> DataList

    {

        get => data;

    }

    public void Add(T element)
    {
        data.Add(element);
    }

    public void Remove(int index)
    {
        data.RemoveAt(index);
    }

    public bool Contains(T element)
    {
        if (data.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int firstElement,int secondElement)
    {
        var temp = data[firstElement];
        data[firstElement] = data[secondElement];
        data[secondElement] = temp;
    }

    public string Greater<T>(T element)
        where T:IComparable
    {
        int count=0;

        foreach (var kvp in data)
        {
            if (element.CompareTo(kvp)<0)
            {
                count++;
            }
        }

        return $"{count}";
    }

    public string Max()
    {
        return $"{data.Max()}";
    }

    public string Min()
    {
        return $"{data.Min()}";
    }



    public IEnumerator<T> GetEnumerator()
    {
        return this.data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}