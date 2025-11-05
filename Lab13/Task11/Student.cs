namespace Task11;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FacultyNumber { get; set; }

    public string FullName => FirstName + " " + LastName;

    public Student(string firstName, string lastName, string facNum)
    {
        FirstName = firstName;
        LastName = lastName;
        FacultyNumber = facNum;
    }
}