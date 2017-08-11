using System;
using System.Linq;

public class Sorter
{
    public static CustomList<T> Sort<T>(CustomList<T> customList)
        where T:IComparable<T>
    {
        var orderList = customList.OrderBy(x => x).ToList();

        var customOrderedList=new CustomList<T>();

        foreach (var kvp in orderList)
        {
            customOrderedList.Add(kvp);
        }

        return customOrderedList;
    }
}