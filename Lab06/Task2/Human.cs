using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace Task2;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Excepted upper case letter! Argument: firstName");
            }

            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }    
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException("Excepted upper case letter! Argument: lastName");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: lastName");
            }    
            lastName = value;       
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First name: {this.FirstName}")
           .AppendLine($"Last name: {this.LastName}");
        return sb.ToString().TrimEnd();   
    }
    
}