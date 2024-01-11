using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Consultations;
using Pri.Pawpi.Core.Services.Models.Medication;
using Pri.Pawpi.Core.Services.Models.Pet;
using Pri.Pawpi.Core.Services.Models.Practice;
using Pri.Pawpi.Core.Services.Models.Specialty;

namespace Pri.Pawpi.Core.Extensions
{
    public static class ModelExtensionMethods
    {
        public static ResultModel<T> ToResultModel<T>(this IEnumerable<T> items)
        {
            var result = new ResultModel<T>
            {
                Items = items,
                IsSuccess = true
            };

            return result;
        }

        public static ResultModel<T> ToErrorModel<T>(this IEnumerable<T> items, string errorMessage)
        {
            var result = new ResultModel<T>
            {
                Errors = new List<string> { errorMessage },
                IsSuccess = false
            };

            return result;
        }

        public static ResultModel<T> ToResultModel<T>(this T item)
        {
            var result = new ResultModel<T>
            {
                Item = item,
                IsSuccess = true
            };

            return result;
        }

        public static ResultModel<T> ToErrorModel<T>(this T item, string errorMessage)
        {
            var result = new ResultModel<T>
            {
                Errors = new List<string> { errorMessage },
                IsSuccess = false
            };

            return result;
        }

        public static void MapEntity(this Person person, PersonModel personModel)
        {
            person.FirstName = personModel.FirstName;
            person.LastName = personModel.LastName;
            person.Birth = personModel.Birth;
            person.Address = personModel.Address;
            person.City = personModel.City;
            person.Postal = personModel.Postal;
            person.Phone = personModel.Phone;
            person.Email = personModel.Email;
        }

        public static void MapEntity(this Consultation consultation, ConsultationAddModel consultationModel)
        {
            consultation.Title = consultationModel.Title;
            consultation.Diagnosis = consultationModel.Diagnosis;
            consultation.Treatment = consultationModel.Treatment;
            consultation.Notes = consultationModel.Notes;
            consultation.DateOfConsultation = consultationModel.DateOfConsultation;
        }

        public static void MapEntity(this Medication medication, MedicationAddModel medicationModel)
        {
            medication.Dosage = medicationModel.Dosage;
            medication.Frequency = medicationModel.Frequency;
            medication.Notes = medicationModel.Notes;
            medication.SideEffects = medicationModel.SideEffects;
        }

        public static void MapEntity(this Specialty specialty, SpecialtyAddModel specialtyModel)
        {
            specialty.Description = specialtyModel.Description;
        }

        public static void MapEntity(this Pet pet, PetAddModel petModel)
        {
            pet.CallName = petModel.CallName;
            pet.Breed = petModel.Breed;
            pet.AnimalType = petModel.AnimalType;
            pet.Color = petModel.Color;
            pet.Weight = petModel.Weight;
        }

        public static void MapEntity(this Practice practice, PracticeAddModel practiceModel)
        {
            practice.Address = practiceModel.Address;
            practice.City = practiceModel.City;
            practice.Postal = practiceModel.Postal;
            practice.Phone = practiceModel.Phone;
            practice.Email = practiceModel.Email;
            practice.OpenTime = practiceModel.OpenTime;
            practice.CloseTime = practiceModel.CloseTime;
        }
    }
}
