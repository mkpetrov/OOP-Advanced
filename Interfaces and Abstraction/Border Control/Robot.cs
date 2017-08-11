public class Robot:IPerson
{
    
    public Robot(string model,string id)
    {
        this.Id = id;
        this.Model = model;
    }

    public string Id { get; private set; }

    public string Model { get; set; }
}