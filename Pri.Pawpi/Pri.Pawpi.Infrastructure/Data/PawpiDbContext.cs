using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data
{
    public class PawpiDbContext :DbContext
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
            //Seeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
