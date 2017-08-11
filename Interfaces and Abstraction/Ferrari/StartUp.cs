using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        var name = Console.ReadLine();

        var car=new Ferrari(name);

        Console.WriteLine(car.ToString());
    }
}
