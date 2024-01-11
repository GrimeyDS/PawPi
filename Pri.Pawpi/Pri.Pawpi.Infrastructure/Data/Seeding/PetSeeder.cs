using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class PetSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>().HasData(
                 new Pet
                 {
                     Id = 1,
                     Name = "Dunehills Love at first sight",
                     CallName = "Bella",
                     Breed = "Golden Retriever",
                     Color = "Golden",
                     AnimalType = "Dog",
                     Weight = 30,
                     CustomerId = 1
                 },
                 new Pet
                 {
                     Id = 2,
                     Name = "New glory to the moon",
                     CallName = "Luna",
                     Breed = "Australian Shepherd",
                     Color = "White/Brown",
                     AnimalType = "Dog",
                     Weight = 20,
                     CustomerId = 1
                 },
                 new Pet
                 {
                     Id = 3,
                     Name = "West horizon blue sky",
                     CallName = "Sky",
                     Breed = "New Foundland",
                     Color = "Black",
                     AnimalType = "Dog",
                     Weight = 50,
                     CustomerId = 2
                 },
                 new Pet
                 {
                     Id = 4,
                     Name = "Left angle handbag",
                     CallName = "Ratty",
                     Breed = "Chihuahua",
                     Color = "Brown",
                     AnimalType = "Dog",
                     Weight = 5,
                     CustomerId = 3
                 },
                 new Pet
                 {
                     Id = 5,
                     Name = "Dark sky thunderstorm",
                     CallName = "Doug",
                     Breed = "German Shepherd",
                     Color = "Black",
                     AnimalType = "Dog",
                     Weight = 40,
                     CustomerId = 2
                 },
                 new Pet
                 {
                     Id = 6,
                     Name = "Seven lives to the sun",
                     CallName = "Sunny",
                     Breed = "Persian",
                     Color = "White",
                     AnimalType = "Cat",
                     Weight = 10,
                     CustomerId = 4
                 },
                 new Pet
                 {
                     Id = 7,
                     Name = "The last of us",
                     CallName = "Ellie",
                     Breed = "Ragdoll",
                     Color = "Brown",
                     AnimalType = "Cat",
                     Weight = 5,
                     CustomerId = 5
                 },
                 new Pet
                 {
                     Id = 8,
                     Name = "Chronicles of ouroboros",
                     CallName = "Mio",
                     Breed = "Maine Coon",
                     Color = "White",
                     AnimalType = "Cat",
                     Weight = 10,
                     CustomerId = 5
                 },
                 new Pet
                 {
                     Id = 9,
                     Name = "Sharktale the blue",
                     CallName = "blub",
                     Breed = "Goldfish",
                     Color = "Gold",
                     AnimalType = "Fish",
                     Weight = 0.5,
                     CustomerId = 1
                 },
                 new Pet
                 {
                     Id = 10,
                     Name = "Dark cold blue sea",
                     CallName = "sink",
                     Breed = "Droge vis",
                     Color = "Blue",
                     AnimalType = "Fish",
                     Weight = 0.2,
                     CustomerId = 2,
                 },
                 new Pet
                 {
                     Id = 11,
                     Name = "Big horse on the field",
                     CallName = "Stallion",
                     Breed = "Horse",
                     Color = "Brown",
                     AnimalType = "Horse",
                     Weight = 500,
                     CustomerId = 3
                 },
                 new Pet
                 {
                     Id = 12,
                     Name = "Slithering down the road",
                     CallName = "Noodle",
                     Breed = "Viper",
                     Color = "Green",
                     AnimalType = "Snake",
                     Weight = 1,
                     CustomerId = 6
                 },
                 new Pet
                 {
                     Id = 13,
                     Name = "Free falling",
                     CallName = "Sylvester",
                     Breed = "Parrot",
                     Color = "Blue/Green/Red",
                     AnimalType = "Bird",
                     Weight = 5,
                     CustomerId = 6
                 },
                 new Pet
                 {
                     Id = 14,
                     Name = "Little ham",
                     CallName = "squeaky",
                     Breed = "Hamster",
                     Color = "Brown",
                     AnimalType = "Hamster",
                     Weight = 5,
                     CustomerId = 7
                 },
                 new Pet
                 {
                     Id = 15,
                     Name = "The big one",
                     CallName = "Biggie",
                     Breed = "Elephant",
                     Color = "Grey",
                     AnimalType = "Elephant",
                     Weight = 5000,
                     CustomerId = 8
                 },
                 new Pet
                 {
                    Id = 16,
                    Name = "The small one",
                    CallName = "Smallie",
                    Breed = "Mouse",
                    Color = "Grey",
                    AnimalType = "Mouse",
                    Weight = 0.5,
                    CustomerId = 999
                 },
                 new Pet
                 {
                    Id = 17,
                    Name = "The big one",
                    CallName = "Biggie",
                    Breed = "Elephant",
                    Color = "Grey",
                    AnimalType = "Elephant",
                    Weight = 5000,
                    CustomerId = 999
                 });
        }
    }
}


