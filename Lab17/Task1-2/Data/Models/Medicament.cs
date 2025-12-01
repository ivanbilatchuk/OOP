namespace Task1.Data.Models;

public class Medicament
{
    public int MedicamentId { get; set; }
    public string Name { get; set; }

    public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
}