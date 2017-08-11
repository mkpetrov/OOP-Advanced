using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        var inputPhoneNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var inputUrls = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

        var phone=new Smartphone();

        foreach (var number in inputPhoneNumbers)
        {
            try
            {
                phone.CallNumber = number;

                Console.WriteLine($"Calling... {number}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        foreach (var url in inputUrls)
        {
            try
            {
                phone.Url = url;

                Console.WriteLine($"Browsing: {url}!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
