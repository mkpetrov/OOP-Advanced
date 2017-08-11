public class Citizen:IPerson
{
    
    public Citizen(string id,string name,int age,string birthdate)
    {
        this.Id = id;
        this.Name = name;
        this.Age = age;
        this.Birthdate = birthdate;
    }

    public string Id { get; private set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Birthdate { get; set; }
}