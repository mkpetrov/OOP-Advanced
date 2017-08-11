using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();



        var input = string.Empty;

        while ((input = Console.ReadLine()) != "END")

        {

            var person = new Person(input.Split().ToList());

            people.Add(person);

        }

        var index = int.Parse(Console.ReadLine());

        var personToCompare = people[index - 1];





        var numberOfEqual = people.Count(person => person.CompareTo(personToCompare) == 0);

        var numberOfNotEqual = people.Count - numberOfEqual;





        if (numberOfEqual == 1)

        {

            Console.WriteLine("No matches");

        }

        else

        {

            Console.WriteLine($"{numberOfEqual} {numberOfNotEqual} {people.Count}");

        }
    }
}
