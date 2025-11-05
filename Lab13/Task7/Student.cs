namespace Task7;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> Grades { get; set; }

    public Student(string firstName, string lastName, List<int> grades)
    {
        FirstName = firstName;
        LastName = lastName;
        Grades = grades;
    }
}