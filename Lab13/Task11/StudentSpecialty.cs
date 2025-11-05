namespace Task11;

class StudentSpecialty
{
    public string SpecialtyName { get; set; }
    public string FacultyNumber { get; set; }

    public StudentSpecialty(string specialtyName, string facNum)
    {
        SpecialtyName = specialtyName;
        FacultyNumber = facNum;
    }
}