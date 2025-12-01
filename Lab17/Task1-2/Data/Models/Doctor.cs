namespace Task1.Data.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
}