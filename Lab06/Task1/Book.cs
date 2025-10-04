using System.Text;

namespace Task1;

public class Book
{
    private string author;
    private string title;
    private decimal price;
    
    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.price = price;
    }

    public string Author
    {
        get
        {
            return this.author;
        }
        set
        {
            string[] parts = value.Split(' ');
            if (parts.Length > 1 && char.IsUpper(parts[1][0]))
            {
                throw new ArgumentException("Author name is invalid.");
            }    
            this.author = value;
        }
    }
    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid.");  
            }    
            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid."); 
            }    
            this.price = value;
        }   
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }
}