using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Pawpi.Infrastructure.Migrations
{
    public partial class adddataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Medication",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Medication",
                columns: new[] { "Id", "Dosage", "Frequency", "Name", "Notes", "SideEffects" },
                values: new object[,]
                {
                    { 1, "2", "Once a day", "Rimadyl", "Rimadyl is a non-steroidal anti-inflammatory drug (NSAID) of the propionic acid class that is used in humans and animals for the relief of pain and inflammation associated with osteoarthritis and for the control of postoperative pain associated with soft tissue and orthopedic surgeries in dogs.", null },
                    { 2, "1", "Twice a day", "Tramadol", "Tramadol, sold under the brand name Ultram among others, is an opioid pain medication used to treat moderate to moderately severe pain. When taken by mouth in an immediate-release formulation, the onset of pain relief usually begins within an hour.", null },
                    { 3, "1", "Twice a day", "Gabapentin", "Gabapentin, sold under the brand name Neurontin among others, is an anticonvulsant medication used to treat partial seizures, neuropathic pain, hot flashes, and restless legs syndrome.", null },
                    { 4, "1", "Three times a day", "Apoquel", "Apoquel is a medication that is used to treat itching and inflammation in dogs caused by a variety of diagnoses. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls itching within 24 hours.", null },
                    { 5, "1", "Twice a day", "Cerenia", "Cerenia is a medication that is used to treat vomiting in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls vomiting within 24 hours.", null },
                    { 6, "1", "Once a day", "Clavamox", "Clavamox is a medication that is used to treat bacterial infections in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls bacterial infections within 24 hours.", null },
                    { 7, "1", "Tree times a day", "Doxycycline", "Doxycycline is a medication that is used to treat bacterial infections in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls bacterial infections within 24 hours.", null },
                    { 8, "1", "Once a day", "Enalapril", "Enalapril is a medication that is used to treat heart failure in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls heart failure within 24 hours.", null },
                    { 9, "1", "Twice a day", "Famotidine", "Famotidine is a medication that is used to treat stomach ulcers in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls stomach ulcers within 24 hours.", null },
                    { 10, "1", "Once a day", "Fluoxetine", "Fluoxetine is a medication that is used to treat anxiety in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls anxiety within 24 hours.", null },
                    { 11, "1", "Twice a day", "Metronidazole", "Metronidazole is a medication that is used to treat diarrhea in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls diarrhea within 24 hours.", null },
                    { 12, "1", "Once a day", "Mirtazapine", "Mirtazapine is a medication that is used to treat appetite loss in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls appetite loss within 24 hours.", null },
                    { 13, "1", "Once a day", "Prednisone", "Prednisone is a medication that is used to treat inflammation in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls inflammation within 24 hours.", null },
                    { 14, "1", "Once a day", "Praziquantel", "Praziquantel is a medication that is used to treat tapeworms in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls tapeworms within 24 hours.", null },
                    { 15, "1", "Once a day", "Simparica", "Simparica is a medication that is used to treat fleas and ticks in dogs. It is a fast-acting drug that starts to work within 4 hours of administration and effectively controls fleas and ticks within 24 hours.", null }
                });

            migrationBuilder.InsertData(
                table: "Practices",
                columns: new[] { "Id", "Address", "City", "CloseTime", "Email", "Name", "OpenTime", "Phone", "Postal" },
                values: new object[,]
                {
                    { 1, "Kerkstraat 1", "Brugge", new DateTime(2021, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "deberenakker@proximus.be", "De Berenakker", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "0478 12 34 56", "8000" },
                    { 2, "Beernemstraat 1", "Beernem", new DateTime(2021, 1, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), "Dedierenvriend@proximus.be", "De Dierenvriend", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "050 12 12 12", "8730" },
                    { 3, "Knesselarestraat 21", "Oedelem", new DateTime(2021, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "hetplatteland@proximus.be", "Het platteland", new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "050 01 02 03", "8730" }
                });

            migrationBuilder.InsertData(
                table: "Specialty",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "General Veterinarian", "General" },
                    { 2, "diagnosis and management of complex diseases related to one or more internal organ systems", "Internal Medicine" },
                    { 3, "repair and treatment of conditions through physical interventions, often by cutting into the body. A Specialist Surgeon is trained in assessing whether a surgery is truly in the best interest of the patient.", "Surgery" },
                    { 4, "treatment of patients who are at death’s door, with life threatening conditions (including emergencies)", "Critical Care" },
                    { 5, "management and treatment of cancer using chemotherapy, radiation, and/or surgery", "Medical, radiation" },
                    { 6, "treatment of skin, fur, and ear conditions", "Dermatology" },
                    { 7, "treatment and surgery of eye conditions", "Ophthalmology" },
                    { 8, "treatment of muscular or skeletal conditions without surgery. This can include sports performance, the management of injury and age related issues, or recovery from surgery.", "Sports medicine & rehabilitation" },
                    { 9, "treatment and surgery of diseases to do with the brain, spinal cord, and muscles (all part of the nervous system)", "Neurology & neurosurgery" },
                    { 10, "veterinary specialists dealing with species that are not dogs or cats (eg. birds, reptiles, rabbits, etc). These specialties can be broken down into more specific species such as Avian Specialist", "Avian & Exotics" },
                    { 11, "acquiring and interpreting medical images (e.g. X-ray, CT, ultrasound, and MRI) to assist with diagnosis and treatment", "Diagnostic imaging" },
                    { 12, " experts in pain relief and management (particularly during surgery), focusing on patient comfort and welfare. Anaesthetists help provide the safest sedation and anaesthetic options for each individual based on their medical condition", "Anaesthesia" },
                    { 13, "determining the cause and nature of diseases by examining and testing body tissues, cells, and fluids", "Pathology" }
                });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "Address", "Birth", "City", "Email", "FirstName", "LastName", "Phone", "Postal" },
                values: new object[,]
                {
                    { 1, "Kerkstraat 1", new DateTime(1991, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "vl@deberenakker.be", "Veerle", "Lauwers", "0478 12 34 56", "8000" },
                    { 2, "Langestraat 56", new DateTime(1981, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "wb@gmail.com", "Wim", "Budddaert", "0478 12 69 99", "9000" },
                    { 3, "Knesselarestraat 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oedelem", "kdv@gmail.com", "Ken", "De Vos", "0488 11 43 39", "8730" },
                    { 4, "Lippenslaan 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knokke", "SanneDZ@telenet.be", "Sanne", "De Zon", "0032459698738", "8310" },
                    { 5, "Kerkstraat 23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "Lottevanputte@proximus.be", "Lotte", "Vanputte", "0032459623438", "8000" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Birth", "City", "Email", "FirstName", "LastName", "Phone", "Postal", "PracticeId" },
                values: new object[,]
                {
                    { 1, "Kerkstraat 1", new DateTime(1991, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "svends@gmail.com", "Sven", "De Schagt", "0478 12 34 56", "8000", 1 },
                    { 2, "Langestraat 56", new DateTime(1981, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "vb@gmail.com", "Jan", "Vanbergen", "0478 12 69 99", "9000", 1 },
                    { 3, "Knesselarestraat 134", new DateTime(1971, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oedelem", "kdv@outlook.com", "Karel", "De Vos", "0488 11 43 39", "8730", 2 },
                    { 4, "Lippenslaan 45", new DateTime(1966, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knokke", "makkermaat@telenet.be", "Makker", "Maat", "0032459698738", "8310", 3 },
                    { 5, "lachenstraat 21", new DateTime(2010, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "sarahdv@proximus.be", "Sarah", "De Vriendt", "0032459698738", "8000", 2 },
                    { 6, "zieligestraat 101", new DateTime(1970, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knokke", "jdv@yahoo.com", "Johan", "De Vriendt", "2345563223", "8310", 2 },
                    { 7, "stommestrat 102", new DateTime(1940, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "mieketjeeeeh@gmail.com", "Mieke", "Vanoverpoel", "0032567844", "9000", 1 },
                    { 8, "stommestrat 102", new DateTime(1950, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gent", "jeffkeeuh@gmail.com", "Jef", "Vanoverpoel", "2234565463", "9000", 2 },
                    { 9, "lachenstraat 21", new DateTime(2010, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brugge", "hansdissen@telenet.be", "Hans", "Dissen", "0032459698738", "8000", 2 },
                    { 10, "Hulstlo 21", new DateTime(1996, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beernem", "chaydz@gmail.com", "Chayenne", "De Zutter", "0032459698738", "8730", 1 }
                });

            migrationBuilder.InsertData(
                table: "PracticeVeterinarian",
                columns: new[] { "PracticesId", "VeterinariansId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "SpecialtyVeterinarian",
                columns: new[] { "SpecialtiesId", "VeterinariansId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "AnimalType", "Breed", "CallName", "Color", "CustomerId", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, "Dog", "Golden Retriever", "Bella", "Golden", 1, "Dunehills Love at first sight", 30.0 },
                    { 2, "Dog", "Australian Shepherd", "Luna", "White/Brown", 1, "New glory to the moon", 20.0 },
                    { 3, "Dog", "New Foundland", "Sky", "Black", 2, "West horizon blue sky", 50.0 },
                    { 4, "Dog", "Chihuahua", "Ratty", "Brown", 3, "Left angle handbag", 5.0 },
                    { 5, "Dog", "German Shepherd", "Doug", "Black", 2, "Dark sky thunderstorm", 40.0 },
                    { 6, "Cat", "Persian", "Sunny", "White", 4, "Seven lives to the sun", 10.0 },
                    { 7, "Cat", "Ragdoll", "Ellie", "Brown", 5, "The last of us", 5.0 },
                    { 8, "Cat", "Maine Coon", "Mio", "White", 5, "Chronicles of ouroboros", 10.0 },
                    { 9, "Fish", "Goldfish", "blub", "Gold", 1, "Sharktale the blue", 0.5 },
                    { 10, "Fish", "Droge vis", "sink", "Blue", 2, "Dark cold blue sea", 0.20000000000000001 },
                    { 11, "Horse", "Horse", "Stallion", "Brown", 3, "Big horse on the field", 500.0 },
                    { 12, "Snake", "Viper", "Noodle", "Green", 6, "Slithering down the road", 1.0 },
                    { 13, "Bird", "Parrot", "Sylvester", "Blue/Green/Red", 6, "Free falling", 5.0 },
                    { 14, "Hamster", "Hamster", "squeaky", "Brown", 7, "Little ham", 5.0 },
                    { 15, "Elephant", "Elephant", "Biggie", "Grey", 8, "The big one", 5000.0 }
                });

            migrationBuilder.InsertData(
                table: "Consultations",
                columns: new[] { "Id", "DateOfConsultation", "Diagnosis", "Notes", "PetId", "Title", "Treatment", "VeterinarianId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1356), "Controle", "Staat wat mager", 1, "First Consultation", "None", 1 },
                    { 2, new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1398), "Hond in kwestie heeft gras gegeten en moet overgeven", "", 1, "Overgeven", "Gaat over", 1 },
                    { 3, new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1401), "Vaccinatie", "", 2, "Vaccinatie", "", 2 },
                    { 4, new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1403), "Tanden zijn slecht onderhouden", "", 3, "Tanden", "Medicatie en poeten", 4 },
                    { 5, new DateTime(2023, 10, 7, 16, 5, 0, 720, DateTimeKind.Local).AddTicks(1406), "Vaccinatie", "", 2, "Vaccinatie", "", 3 }
                });

            migrationBuilder.InsertData(
                table: "MedicationPet",
                columns: new[] { "MedicationsId", "PetsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 5 },
                    { 10, 5 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 7 },
                    { 13, 8 },
                    { 14, 7 },
                    { 14, 9 },
                    { 15, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Consultations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 14, 9 });

            migrationBuilder.DeleteData(
                table: "MedicationPet",
                keyColumns: new[] { "MedicationsId", "PetsId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PracticeVeterinarian",
                keyColumns: new[] { "PracticesId", "VeterinariansId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SpecialtyVeterinarian",
                keyColumns: new[] { "SpecialtiesId", "VeterinariansId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Veterinarians",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Practices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Practices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Practices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Medication",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
