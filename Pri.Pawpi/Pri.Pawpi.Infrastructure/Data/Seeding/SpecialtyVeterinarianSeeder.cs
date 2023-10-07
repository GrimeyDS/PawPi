using Microsoft.EntityFrameworkCore;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class SpecialtyVeterinarianSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("SpecialtyVeterinarian").HasData(
                new { SpecialtiesId = 1, VeterinariansId = 1 },
                new { SpecialtiesId = 1, VeterinariansId = 2 },
                new { SpecialtiesId = 2, VeterinariansId = 3 },
                new { SpecialtiesId = 2, VeterinariansId = 4 },
                new { SpecialtiesId = 3, VeterinariansId = 5 },
                new { SpecialtiesId = 3, VeterinariansId = 1 },
                new { SpecialtiesId = 1, VeterinariansId = 3 }
                );
        }
    }
}
