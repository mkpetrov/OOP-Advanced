using System.Collections;
using System.Collections.Generic;

public class Lake<T>:IEnumerable<T>
{
    private List<T> collection;

    public Lake(params T[]data)
    {
        this.collection=new List<T>(data);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < collection.Count; i++)

        {

            if (i % 2 == 0)

            {

                yield return collection[i];

            }

        }

        for (int i = collection.Count - 1; i >= 0; i--)

        {

            if (i % 2 != 0)

            {

                yield return collection[i];

            }

        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}