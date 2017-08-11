using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        var inputLine = Console.ReadLine();

        var persons=new List<Citizen>();
        var pets=new List<Pet>();

        while (inputLine != "End")
        {
            var inputParts = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (inputParts.Length==5)
            {
                var citizen=new Citizen(inputParts[3],inputParts[1],int.Parse(inputParts[2]),inputParts[4]);
                persons.Add(citizen);
            }
            else
            {
                if (inputParts[0]=="Pet")
                {
                    var pet=new Pet(inputParts[2]);
                    pets.Add(pet);
                }
                
            }

            inputLine = Console.ReadLine();
        }

        var filter = Console.ReadLine();

        var output=new List<string>();

        persons.Where(p=>p.Birthdate.EndsWith(filter)).ToList().ForEach(p=>output.Add(p.Birthdate));
        pets.Where(p=>p.Birthdate.EndsWith(filter)).ToList().ForEach(p => output.Add(p.Birthdate));

        foreach (var kvp in output)
        {
            Console.WriteLine(kvp);
        }
    }
}
