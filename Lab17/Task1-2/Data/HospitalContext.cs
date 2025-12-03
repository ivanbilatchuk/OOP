using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Task1.Data.Models;

namespace Task1.Data;

public class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
    {
    }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Visitation> Visitations { get; set; }
    public DbSet<Diagnose> Diagnoses { get; set; } 
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<PatientMedicament> PatientMedicaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }    
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId);
            entity.Property(e => e.FirstName).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.LastName).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.Address).HasMaxLength(250).IsUnicode(true);
            entity.Property(e => e.Email).HasMaxLength(80).IsUnicode(false);
        });
        modelBuilder.Entity<Diagnose>(entity =>
        {
            entity.HasKey(e => e.DiagnoseId);
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(true);
            entity.Property(e => e.Comments).HasMaxLength(250).IsUnicode(true);
        });
        modelBuilder.Entity<Visitation>(entity =>
        {
            entity.HasKey(e => e.VisitationId);
            entity.Property(e => e.Comments).HasMaxLength(250).IsUnicode(true);    
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.HasKey(e => e.MedicamentId);
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(true);
        });

        modelBuilder.Entity<PatientMedicament>()
            .HasKey(pm => new { pm.PatientId, pm.MedicamentId });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId);
            entity.Property(e => e.Name).HasMaxLength(100).IsUnicode(true);
            entity.Property(e => e.Specialty).HasMaxLength(100).IsUnicode(true);
        });

    }

}