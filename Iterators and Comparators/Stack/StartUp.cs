using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var stack=new CustomStack<string>();

        while (input!="END")
        {
            var inputCommand = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (inputCommand[0]=="Push")
            {
                stack.Push(inputCommand.Skip(1).ToArray());
            }
            else
            {
                stack.Pop();
            }

            input = Console.ReadLine();
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var element in stack.Reverse())
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
