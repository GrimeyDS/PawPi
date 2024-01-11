using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class CustomerSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        Id = 1,
                        FirstName = "Sven",
                        LastName = "De Schagt",
                        Email = "svends@gmail.com",
                        Phone = "0478 12 34 56",
                        Address = "Kerkstraat 1",
                        City = "Brugge",
                        Postal = "8000",
                        Birth = new DateTime(1991, 1, 3),
                        PracticeId = 1
                    },
                    new Customer
                    {
                        Id = 2,
                        FirstName = "Jan",
                        LastName = "Vanbergen",
                        Email = "vb@gmail.com",
                        Phone = "0478 12 69 99",
                        Address = "Langestraat 56",
                        City = "Gent",
                        Postal = "9000",
                        Birth = new DateTime(1981, 2, 18),
                        PracticeId = 1
                    },
                    new Customer
                    {
                        Id = 3,
                        FirstName = "Karel",
                        LastName = "De Vos",
                        Email = "kdv@outlook.com",
                        Phone = "0488 11 43 39",
                        Address = "Knesselarestraat 134",
                        City = "Oedelem",
                        Postal = "8730",
                        Birth = new DateTime(1971, 5, 23),
                        PracticeId = 2
                    },
                    new Customer
                    {
                        Id = 4,
                        FirstName = "Makker",
                        LastName = "Maat",
                        Email = "makkermaat@telenet.be",
                        Phone = "0032459698738",
                        Address = "Lippenslaan 45",
                        City = "Knokke",
                        Postal = "8310",
                        Birth = new DateTime(1966, 6, 12),
                        PracticeId = 3
                    },
                    new Customer
                    {
                        Id = 5,
                        FirstName = "Sarah",
                        LastName = "De Vriendt",
                        Email = "sarahdv@proximus.be",
                        Phone = "0032459698738",
                        Address = "lachenstraat 21",
                        City = "Brugge",
                        Postal = "8000",
                        Birth = new DateTime(2010, 2, 14),
                        PracticeId = 2
                    },
                    new Customer
                    {
                        Id = 6,
                        FirstName = "Johan",
                        LastName = "De Vriendt",
                        Email = "jdv@yahoo.com",
                        Phone = "2345563223",
                        Address = "zieligestraat 101",
                        City = "Knokke",
                        Postal = "8310",
                        Birth = new DateTime(1970, 2, 14),
                        PracticeId = 2
                    },
                    new Customer
                    {
                        Id = 7,
                        FirstName = "Mieke",
                        LastName = "Vanoverpoel",
                        Email = "mieketjeeeeh@gmail.com",
                        Phone = "0032567844",
                        Address = "stommestrat 102",
                        City = "Gent",
                        Postal = "9000",
                        Birth = new DateTime(1940, 1, 11),
                        PracticeId = 1
                    },
                    new Customer
                    {
                        Id = 8,
                        FirstName = "Jef",
                        LastName = "Vanoverpoel",
                        Email = "jeffkeeuh@gmail.com",
                        Phone = "2234565463",
                        Address = "stommestrat 102",
                        City = "Gent",
                        Postal = "9000",
                        Birth = new DateTime(1950, 5, 12),
                        PracticeId = 2
                    },
                    new Customer
                    {
                        Id = 9,
                        FirstName = "Hans",
                        LastName = "Dissen",
                        Email = "hansdissen@telenet.be",
                        Phone = "0032459698738",
                        Address = "lachenstraat 21",
                        City = "Brugge",
                        Postal = "8000",
                        Birth = new DateTime(2010, 2, 14),
                        PracticeId = 2
                    },
                    new Customer
                    {
                        Id = 10,
                        FirstName = "Chayenne",
                        LastName = "De Zutter",
                        Email = "chaydz@gmail.com",
                        Phone = "0032459698738",
                        Address = "Hulstlo 21",
                        City = "Beernem",
                        Postal = "8730",
                        Birth = new DateTime(1996, 6, 23),
                        PracticeId = 1
                    },
                    new Customer
                    {
                        Id = 999,
                        FirstName = "Test",
                        LastName = "Test",
                        Email = "Customer@test.com",
                        Phone = "0032459698738",
                        Address = "Test",
                        City = "Test",
                        Postal = "9999",
                        Birth = new DateTime(1996, 6, 23),
                        PracticeId = 999
                    },
                    new Customer
                    {
                        Id = 11,
                        FirstName = "chay",
                        LastName = "De Zutter",
                        Email = "chaydz@gmail.com",
                        Phone = "0032459698738",
                        Address = "Hulstlo 21",
                        City = "Beernem",
                        Postal = "8730",
                        Birth = new DateTime(1996, 6, 23),
                        PracticeId = 999
                    }
                );
        }
    }
}
