namespace Task9;

class Student
{
    public string FacultyNumber { get; set; }
    public List<int> Grades { get; set; }

    public Student(string facultyNumber, List<int> grades)
    {
        FacultyNumber = facultyNumber;
        Grades = grades;
    }
}