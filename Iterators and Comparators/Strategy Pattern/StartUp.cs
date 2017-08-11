using System;

using System.Collections.Generic;



namespace StrategyPattern

{

    public class Program

    {

        public static void Main(string[] args)

        {

            SortedSet<Person> peopleByName = new SortedSet<Person>(new NameComparator());

            SortedSet<Person> peopleByAge = new SortedSet<Person>(new AgeComparator());



            var rows = int.Parse(Console.ReadLine());



            for (int i = 0; i < rows; i++)

            {

                var input = Console.ReadLine().Split();

                var name = input[0];

                var age = int.Parse(input[1]);



                peopleByAge.Add(new Person(name, age));

                peopleByName.Add(new Person(name, age));

            }

            PrintSet(peopleByName);

            PrintSet(peopleByAge);

        }



        public static void PrintSet(SortedSet<Person> collection)

        {

            foreach (var person in collection)

            {

                Console.WriteLine(person.ToString());

            }

        }

    }

}