namespace Task1;

public class Smartphone : ICallable, IBrowsable
{
    public string Call(string number)
    {
        foreach (char ch in number)
        {
            if (!char.IsDigit(ch))
            {
                return "Invalid number!";
            }   
        }

        return $"Calling... {number}";
    }
    public string Browse(string url)
    {
        foreach (char ch in url)
        {
            if (char.IsDigit(ch))
            {
                return "Invalid URL!";
            }
        }    
        return $"Browsing: {url}!";
    }   
}