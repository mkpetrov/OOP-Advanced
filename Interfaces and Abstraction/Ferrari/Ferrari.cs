public class Ferrari:ICar
{
    private string model= "488-Spider";
    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Model { get; }

    public string Driver
    {
        get { return this.driver; }
        set { this.driver = value; }
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.model}/{Brake()}/{Gas()}/{this.driver}";
    }
}