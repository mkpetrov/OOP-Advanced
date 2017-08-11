using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        IList<Box<double>> listOfBoxes=new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();

            var box=new Box<double>(double.Parse(input));

            listOfBoxes.Add(box);
        }

        var element = double.Parse(Console.ReadLine());

        Console.WriteLine(GetGreaterElementsCount(listOfBoxes,element));
    }

    private static int GetGreaterElementsCount<T>(IList<Box<double>> listOfBoxes, T element)
        where T : IComparable
        => listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);

}
