using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class ConsultationSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultation>().HasData(
                new Consultation
                {
                    Id = 1,
                    Title = "First Consultation",
                    Diagnosis = "Controle",
                    Treatment = "None",
                    Notes = "Staat wat mager",
                    DateOfConsultation = DateTime.Now,
                    VeterinarianId = 1,
                    PetId = 1
                },
                new Consultation
                {
                    Id = 2,
                    Title = "Overgeven",
                    Diagnosis = "Hond in kwestie heeft gras gegeten en moet overgeven",
                    Treatment = "Gaat over",
                    Notes = "",
                    DateOfConsultation = DateTime.Now,
                    VeterinarianId = 1,
                    PetId = 1
                },
                new Consultation
                {
                    Id = 3,
                    Title = "Vaccinatie",
                    Diagnosis = "Vaccinatie",
                    Treatment = "",
                    Notes = "",
                    DateOfConsultation = DateTime.Now,
                    VeterinarianId = 2,
                    PetId = 2
                },
                new Consultation
                {
                    Id = 4,
                    Title = "Tanden",
                    Diagnosis = "Tanden zijn slecht onderhouden",
                    Treatment = "Medicatie en poeten",
                    Notes = "",
                    DateOfConsultation = DateTime.Now,
                    VeterinarianId = 4,
                    PetId = 3
                },
                new Consultation
                {
                    Id = 5,
                    Title = "Vaccinatie",
                    Diagnosis = "Vaccinatie",
                    Treatment = "",
                    Notes = "",
                    DateOfConsultation = DateTime.Now,
                    VeterinarianId =3,
                    PetId = 2
                }
                );
                
                
        }
    }
}
