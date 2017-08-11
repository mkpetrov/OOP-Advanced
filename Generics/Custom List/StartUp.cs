using System;

public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        CustomList<string> list=new CustomList<string>();

        while (input!="END")
        {
            var inputParts = input.Split(' ');

            switch (inputParts[0])
            {
                case "Add":
                    list.Add(inputParts[1]);
                    break;
                case "Remove":
                    list.Remove(int.Parse(inputParts[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(inputParts[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(inputParts[1]),int.Parse(inputParts[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.Greater(inputParts[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Sort":
                    list = Sorter.Sort(list);
                    break;
                case "Print":

                    foreach (var element in list)
                    {
                        Console.WriteLine($"{element}");
                    }
                    break;
                   
            }

            input = Console.ReadLine();
        }
    }
}
