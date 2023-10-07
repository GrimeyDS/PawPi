using Microsoft.EntityFrameworkCore;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class MedicationPetSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("MedicationPet").HasData(
                new { PetsId = 1, MedicationsId = 1 },
                new { PetsId = 1, MedicationsId = 2 },
                new { PetsId = 2, MedicationsId = 3 },
                new { PetsId = 2, MedicationsId = 4 },
                new { PetsId = 3, MedicationsId = 5 },
                new { PetsId = 3, MedicationsId = 6 },
                new { PetsId = 4, MedicationsId = 7 },
                new { PetsId = 4, MedicationsId = 8 },
                new { PetsId = 5, MedicationsId = 9 },
                new { PetsId = 5, MedicationsId = 10 },
                new { PetsId = 6, MedicationsId = 11 },
                new { PetsId = 6, MedicationsId = 12 },
                new { PetsId = 7, MedicationsId = 13 },
                new { PetsId = 7, MedicationsId = 14 },
                new { PetsId = 8, MedicationsId = 15 },
                new { PetsId = 8, MedicationsId = 13 },
                new { PetsId = 9, MedicationsId = 14 }
                );
        }
    }
}

