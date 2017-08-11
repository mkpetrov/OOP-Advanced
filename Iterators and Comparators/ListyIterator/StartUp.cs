using System;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        var create = Console.ReadLine().Split(' ');

        var list = create.Skip(1).ToArray();

        var iterator=new ListyIterator<string>(list);

        var command = Console.ReadLine();

        while (command!="END")
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine($"{iterator.Move()}");
                    break;
                case "Print":
                    iterator.Print();
                    break;
                case "HasNext":
                    Console.WriteLine($"{iterator.HasNext()}");
                    break;
                case "PrintAll":
                    Console.WriteLine(string.Join(" ",iterator));
                    break;
            }

            command = Console.ReadLine();
        }
    }
}
