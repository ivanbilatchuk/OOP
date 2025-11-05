namespace Task6;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public Student(string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }
}