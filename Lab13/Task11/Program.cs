using Task11;

class Program
{
    static void Main()
    {
        List<StudentSpecialty> specialties = new List<StudentSpecialty>();
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "Students:")
        {
            string[] parts = input.Split(' ');
            string specialty = parts[0] + " " + parts[1];
            string facNum = parts[2];
            specialties.Add(new StudentSpecialty(specialty, facNum));
        }
        
        while ((input = Console.ReadLine()) != "END")
        {
            string[] parts = input.Split(' ');
            string facNum = parts[0];
            string firstName = parts[1];
            string lastName = parts[2];
            students.Add(new Student(firstName, lastName, facNum));
        }
        
        var result = students
            .Join(specialties,
                st => st.FacultyNumber,
                sp => sp.FacultyNumber,
                (st, sp) => new
                {
                    Name = st.FirstName + " " + st.LastName,
                    FacultyNumber = st.FacultyNumber,
                    Specialty = sp.SpecialtyName
                })
            .OrderByDescending(r => r.Name) 
            .ThenBy(r => r.FacultyNumber);
        
        foreach (var r in result)
        {
            Console.WriteLine($"{r.Name} {r.FacultyNumber} {r.Specialty}");
        }
    }
}