using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private List<T> data;

    public Box()
    {
        this.data=new List<T>();
    }

    public void Add(T element)
    {
        this.data.Insert(0,element);
    }

    public T Remove()
    {
        var rem = this.data.FirstOrDefault();
        this.data.RemoveAt(0);
        return rem;
    }

    public int Count => this.data.Count;
}