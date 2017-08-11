using System;
using System.Linq;

public class Smartphone:ICall,IBrowse
{
    private string url;
    private string callNumber;

    public Smartphone()
    {
        
    }

    public string Url
    {
        get { return this.url; }
        set 
        {
            if (value.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }

            this.url = value;
        }
    }

    public string CallNumber
    {
        get { return this.callNumber; }
        set
        {
            if (value.Any(char.IsLetter))
            {
                throw new ArgumentException("Invalid number!");
            }

            this.callNumber = value;
        }
    }
}