using Microsoft.EntityFrameworkCore;


namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class PracticeVeterinarianSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("PracticeVeterinarian").HasData(
                new { PracticesId = 1, VeterinariansId = 1 },
                new { PracticesId = 1, VeterinariansId = 2 },
                new { PracticesId = 2, VeterinariansId = 3 },
                new { PracticesId = 2, VeterinariansId = 4 },
                new { PracticesId = 3, VeterinariansId = 5 },
                new { PracticesId = 3, VeterinariansId = 1 },
                new { PracticesId = 2, VeterinariansId = 999 },
                new { PracticesId = 3, VeterinariansId = 999 },
                new { PracticesId = 1, VeterinariansId = 3 }
                );
        }
    }
}
