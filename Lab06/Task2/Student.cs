namespace Task2;

public class Student : Human
{
    private string facultyNumber;
    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !IsAlphaNumeric(value))
            {
                throw new ArgumentException("Invalid faculty number!");  
            }    
            facultyNumber = value;       
        }
    }

    private bool IsAlphaNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }   
        }
        return true;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nFaculty number: {this.FacultyNumber}";
    }
}