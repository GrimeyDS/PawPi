using Microsoft.EntityFrameworkCore;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Infrastructure.Data.Seeding
{
    public class SpecialtySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialty>().HasData(
                 new Specialty
                 {
                     Id = 1,
                     Name = "General",
                     Description = "General Veterinarian"
                 },
                 new Specialty
                 {
                     Id = 2,
                     Name = "Internal Medicine",
                     Description = "diagnosis and management of complex diseases related to one or more internal organ systems"
                 },
                 new Specialty
                 {
                     Id = 3,
                     Name = "Surgery",
                     Description = "repair and treatment of conditions through physical interventions, often by cutting into the body. A Specialist Surgeon is trained in assessing whether a surgery is truly in the best interest of the patient."
                 },
                 new Specialty
                 {
                     Id = 4,
                     Name = "Critical Care",
                     Description = "treatment of patients who are at death’s door, with life threatening conditions (including emergencies)"
                 },
                 new Specialty
                 {
                     Id = 5,
                     Name = "Medical, radiation",
                     Description = "management and treatment of cancer using chemotherapy, radiation, and/or surgery"
                 },
                 new Specialty
                 {
                     Id = 6,
                     Name = "Dermatology",
                     Description = "treatment of skin, fur, and ear conditions"
                 },
                 new Specialty
                 {
                     Id = 7,
                     Name = "Ophthalmology",
                     Description = "treatment and surgery of eye conditions"
                 },
                 new Specialty
                 {
                     Id = 8,
                     Name = "Sports medicine & rehabilitation",
                     Description = "treatment of muscular or skeletal conditions without surgery. This can include sports performance, the management of injury and age related issues, or recovery from surgery."
                 },
                 new Specialty
                 {
                     Id = 9,
                     Name = "Neurology & neurosurgery",
                     Description = "treatment and surgery of diseases to do with the brain, spinal cord, and muscles (all part of the nervous system)"
                 },
                 new Specialty
                 {
                     Id = 10,
                     Name = "Avian & Exotics",
                     Description = "veterinary specialists dealing with species that are not dogs or cats (eg. birds, reptiles, rabbits, etc). These specialties can be broken down into more specific species such as Avian Specialist"
                 },
                 new Specialty
                 {
                     Id = 11,
                     Name = "Diagnostic imaging",
                     Description = "acquiring and interpreting medical images (e.g. X-ray, CT, ultrasound, and MRI) to assist with diagnosis and treatment"
                 },
                 new Specialty
                 {
                     Id = 12,
                     Name = "Anaesthesia",
                     Description = " experts in pain relief and management (particularly during surgery), focusing on patient comfort and welfare. Anaesthetists help provide the safest sedation and anaesthetic options for each individual based on their medical condition"
                 },
                 new Specialty
                 {
                     Id = 13,
                     Name = "Pathology",
                     Description = "determining the cause and nature of diseases by examining and testing body tissues, cells, and fluids"
                 });
        }
    }
}
