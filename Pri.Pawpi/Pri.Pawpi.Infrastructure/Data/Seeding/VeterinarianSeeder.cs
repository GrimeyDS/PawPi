using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class VeterinarianSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veterinarian>().HasData(
                    new Veterinarian
                    {
                        Id = 1,
                        FirstName = "Veerle",
                        LastName = "Lauwers",
                        Email = "vl@deberenakker.be",
                        Phone = "0478 12 34 56",
                        Address = "Kerkstraat 1",
                        City = "Brugge",
                        Postal = "8000",
                        Birth = new DateTime(1991, 1, 3),
                    },
                    new Veterinarian
                    {
                        Id = 2,
                        FirstName = "Wim",
                        LastName = "Budddaert",
                        Email = "wb@gmail.com",
                        Phone = "0478 12 69 99",
                        Address = "Langestraat 56",
                        City = "Gent",
                        Postal = "9000",
                        Birth = new DateTime(1981, 2, 18),
                    },
                    new Veterinarian
                    {
                        Id = 3,
                        FirstName = "Ken",
                        LastName = "De Vos",
                        Email = "kdv@gmail.com",
                        Phone = "0488 11 43 39",
                        Address = "Knesselarestraat 13",
                        City = "Oedelem",
                        Postal = "8730",
                    },
                    new Veterinarian
                    {
                        Id = 4,
                        FirstName = "Sanne",
                        LastName = "De Zon",
                        Email = "SanneDZ@telenet.be",
                        Phone = "0032459698738",
                        Address = "Lippenslaan 12",
                        City = "Knokke",
                        Postal = "8310",
                    },
                    new Veterinarian
                    {
                        Id = 5,
                        FirstName = "Lotte",
                        LastName = "Vanputte",
                        Email = "Lottevanputte@proximus.be",
                        Phone = "0032459623438",
                        Address = "Kerkstraat 23",
                        City = "Brugge",
                        Postal = "8000"
                    });
        }
    }
}
