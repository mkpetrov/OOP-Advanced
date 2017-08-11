using System.Collections.Generic;



namespace StrategyPattern

{

    public class NameComparator : IComparer<Person>

    {

        public int Compare(Person x, Person y)

        {

            if (x.Name.Length == y.Name.Length)

            {

                return char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));

            }

            return x.Name.Length.CompareTo(y.Name.Length);



        }

    }

}