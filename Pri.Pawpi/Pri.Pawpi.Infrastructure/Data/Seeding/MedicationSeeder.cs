using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class MedicationSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medication>().HasData(
                new Medication
                {
                    Id = 1,
                    Name = "Rimadyl",
                    Notes = "Rimadyl is a non-steroidal anti-inflammatory drug (NSAID) of the propionic acid class that is used in humans and animals for the relief of pain and inflammation associated with osteoarthritis and for the control of postoperative pain associated with soft tissue and orthopedic surgeries in dogs.",
                    Dosage = "2",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 2,
                    Name = "Tramadol",
                    Notes = "Tramadol, sold under the brand name Ultram among others, is an opioid pain medication used to treat moderate to moderately severe pain. When taken by mouth in an immediate-release formulation, the onset of pain relief usually begins within an hour.",
                    Dosage = "1",
                    Frequency = "Twice a day",
                },
                new Medication
                {
                    Id = 3,
                    Name = "Gabapentin",
                    Notes = "Gabapentin, sold under the brand name Neurontin among others, is an anticonvulsant medication used to treat partial seizures, neuropathic pain, hot flashes, and restless legs syndrome.",
                    Dosage = "1",
                    Frequency = "Twice a day",
                },
                new Medication
                {
                    Id = 4,
                    Name = "Apoquel",
                    Notes = "Apoquel is a medication that is used to treat itching and inflammation in dogs caused by a variety of diagnoses. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls itching within 24 hours.",
                    Dosage = "1",
                    Frequency = "Three times a day",
                },
                new Medication
                {
                    Id = 5,
                    Name = "Cerenia",
                    Notes = "Cerenia is a medication that is used to treat vomiting in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls vomiting within 24 hours.",
                    Dosage = "1",
                    Frequency = "Twice a day",
                },
                new Medication
                {
                    Id = 6,
                    Name = "Clavamox",
                    Notes = "Clavamox is a medication that is used to treat bacterial infections in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls bacterial infections within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 7,
                    Name = "Doxycycline",
                    Notes = "Doxycycline is a medication that is used to treat bacterial infections in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls bacterial infections within 24 hours.",
                    Dosage = "1",
                    Frequency = "Tree times a day",
                },
                new Medication
                {
                    Id = 8,
                    Name = "Enalapril",
                    Notes = "Enalapril is a medication that is used to treat heart failure in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls heart failure within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 9,
                    Name = "Famotidine",
                    Notes = "Famotidine is a medication that is used to treat stomach ulcers in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls stomach ulcers within 24 hours.",
                    Dosage = "1",
                    Frequency = "Twice a day",
                },
                new Medication
                {
                    Id = 10,
                    Name = "Fluoxetine",
                    Notes = "Fluoxetine is a medication that is used to treat anxiety in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls anxiety within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 11,
                    Name = "Metronidazole",
                    Notes = "Metronidazole is a medication that is used to treat diarrhea in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls diarrhea within 24 hours.",
                    Dosage = "1",
                    Frequency = "Twice a day",
                },
                new Medication
                {
                    Id = 12,
                    Name = "Mirtazapine",
                    Notes = "Mirtazapine is a medication that is used to treat appetite loss in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls appetite loss within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 13,
                    Name = "Prednisone",
                    Notes = "Prednisone is a medication that is used to treat inflammation in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls inflammation within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 14,
                    Name = "Praziquantel",
                    Notes = "Praziquantel is a medication that is used to treat tapeworms in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls tapeworms within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                },
                new Medication
                {
                    Id = 15,
                    Name = "Simparica",
                    Notes = "Simparica is a medication that is used to treat fleas and ticks in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls fleas and ticks within 24 hours.",
                    Dosage = "1",
                    Frequency = "Once a day",
                });
        }
    }
}
