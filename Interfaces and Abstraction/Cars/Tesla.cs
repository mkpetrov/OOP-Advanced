using System;
using System.Text;

public class Tesla:ICar,IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Battery { get; private set; }

    public Tesla(string model,string color,int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = batteries;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
       return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Color} Tesla {this.Model}");
        sb.AppendLine(Start());
        sb.Append(Stop());

        return sb.ToString();
    }
}