using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public Person(List<string> tokens)

    {

        this.Name = tokens[0];

        this.Age = int.Parse(tokens[1]);

        this.Town = tokens[2];

    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Town { get; set; }

    public int CompareTo(Person other)
    {
        if (this.Name!=other.Name)
        {
            return this.Name.CompareTo(other.Name);
        }

        if (this.Age!=other.Age)
        {
            return this.Age.CompareTo(other.Age);
        }

        return this.Town.CompareTo(other.Town);
    }
}