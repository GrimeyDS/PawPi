using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Infrastructure.Data.Seeding;

namespace Pri.Pawpi.Infrastructure.Data
{
    public class PawpiDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Practice> Practices { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Consultation> Consultations { get; set; } 
        public DbSet<Medication> Medication { get; set; }

        public PawpiDbContext(DbContextOptions<PawpiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Practice Fluent API
            modelBuilder.Entity<Practice>()
                        .Property(p => p.Name)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Practice>()
                        .Property(p => p.Address)
                        .IsRequired(true)
                        .HasMaxLength(100);
            modelBuilder.Entity<Practice>()
                        .Property(p => p.City)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Practice>()
                        .Property(p => p.Email)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Practice>()
                        .Property(p => p.Phone)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Practice>()
                        .Property(p => p.Postal)
                        .IsRequired(true)
                        .HasMaxLength(50);
            #endregion

            #region Veterinarian Fluent API
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.FirstName)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.LastName)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.Email)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.Phone)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.Address)
                        .IsRequired(true)
                        .HasMaxLength(100);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.City)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.Postal)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Veterinarian>()
                        .Property(v => v.Birth)
                        .IsRequired(true);
            #endregion

            #region Customer Fluent API
            modelBuilder.Entity<Customer>()
                        .Property(c => c.FirstName)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.LastName)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.Email)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.Phone)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.Address)
                        .IsRequired(true)
                        .HasMaxLength(100);
            modelBuilder.Entity<Customer>()
                     .Property(c => c.City)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.Postal)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                        .Property(c => c.Birth)
                        .IsRequired(true);
            #endregion

            #region Pet Fluent API
            modelBuilder.Entity<Pet>()
                        .Property(p => p.Name)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Pet>()
                        .Property(p => p.CallName)
                        .IsRequired(false)
                        .HasMaxLength(50);
            modelBuilder.Entity<Pet>()
                        .Property(p => p.Breed)
                        .IsRequired(false)
                        .HasMaxLength(50);
            modelBuilder.Entity<Pet>()
                        .Property(p => p.Color)
                        .IsRequired(false)
                        .HasMaxLength(50);
            modelBuilder.Entity<Pet>()
                        .Property(p => p.AnimalType)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Pet>()
                        .Property(p => p.Weight)
                        .IsRequired(false);
            #endregion

            #region Consultation Fluent API
            modelBuilder.Entity<Consultation>()
                        .Property(c => c.Title)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Consultation>()
                        .Property(c => c.Diagnosis)
                        .IsRequired(true)
                        .HasMaxLength(250);
            modelBuilder.Entity<Consultation>()
                        .Property(c => c.Treatment)
                        .IsRequired(false)
                        .HasMaxLength(250);
            modelBuilder.Entity<Consultation>()
                        .Property(c => c.Notes)
                        .IsRequired(false)
                        .HasMaxLength(250);
            modelBuilder.Entity<Consultation>()
                        .Property(c => c.DateOfConsultation)
                        .IsRequired(true);
            #endregion

            #region Medication Fluent API
            modelBuilder.Entity<Medication>()
                        .Property(m => m.Name)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Medication>()
                        .Property(m => m.Dosage)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Medication>()
                        .Property(m => m.Frequency)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Medication>()
                        .Property(m => m.Notes)
                        .IsRequired(false)
                        .HasMaxLength(500);
            modelBuilder.Entity<Medication>()
                        .Property(m => m.SideEffects)
                        .IsRequired(false)
                        .HasMaxLength(250);
            #endregion

            #region Specialty Fluent API
            modelBuilder.Entity<Specialty>()
                        .Property(s => s.Name)
                        .IsRequired(true)
                        .HasMaxLength(50);
            modelBuilder.Entity<Specialty>()
                        .Property(s => s.Description)
                        .IsRequired(false)
                        .HasMaxLength(250);
            #endregion

            #region Seeding Data
            ConsultationSeeder.Seed(modelBuilder);
            MedicationSeeder.Seed(modelBuilder);
            PracticeSeeder.Seed(modelBuilder);
            SpecialtySeeder.Seed(modelBuilder);
            VeterinarianSeeder.Seed(modelBuilder);
            CustomerSeeder.Seed(modelBuilder);
            PetSeeder.Seed(modelBuilder);
            PracticeVeterinarianSeeder.Seed(modelBuilder);
            SpecialtyVeterinarianSeeder.Seed(modelBuilder);
            MedicationPetSeeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
            #endregion
        }
    }
}
