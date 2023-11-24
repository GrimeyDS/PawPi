using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class PracticeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Practice>().HasData(
                new Practice
                {
                    Id = 1,
                    Name = "De Berenakker",
                    Address = "Kerkstraat 1",
                    City = "Brugge",
                    Postal = "8000",
                    Phone = "0478 12 34 56",
                    Email = "deberenakker@proximus.be",
                    OpenTime = new DateTime(2021, 1, 1, 8, 0, 0),
                    CloseTime = new DateTime(2021, 1, 1, 18, 0, 0)
                },
                new Practice
                {
                    Id = 2,
                    Name = "De Dierenvriend",
                    Address = "Beernemstraat 1",
                    City = "Beernem",
                    Postal = "8730",
                    Phone = "050 12 12 12",
                    Email = "Dedierenvriend@proximus.be",
                    OpenTime = new DateTime(2021, 1, 1, 8, 0, 0),
                    CloseTime = new DateTime(2021, 1, 1, 20, 0, 0)
                },
                new Practice
                {
                    Id = 3,
                    Name = "Het platteland",
                    Address = "Knesselarestraat 21",
                    City = "Oedelem",
                    Postal = "8730",
                    Phone = "050 01 02 03",
                    Email = "hetplatteland@proximus.be",
                    OpenTime = new DateTime(2021, 1, 1, 8, 0, 0),
                    CloseTime = new DateTime(2021, 1, 1, 19, 0, 0)
                },
                new Practice
                {
                    Id = 999,
                    Name = "Test",
                    Address = "Test",
                    City = "Test",
                    Postal = "Test",
                    Phone = "Test",
                    Email = "Practice@test.com",
                    OpenTime = new DateTime(2021, 1, 1, 8, 0, 0),
                    CloseTime = new DateTime(2021, 1, 1, 19, 0, 0)
                });
        }
    }
}
