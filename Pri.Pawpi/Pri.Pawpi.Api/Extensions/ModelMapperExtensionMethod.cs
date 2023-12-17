using Pri.Pawpi.Api.Dtos.Consultation.Request;
using Pri.Pawpi.Api.Dtos.Medication.Request;
using Pri.Pawpi.Api.Dtos.Pet.Request;
using Pri.Pawpi.Api.Dtos.Practice.Request;
using Pri.Pawpi.Api.Dtos.Specialty.Request;
using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using Pri.Pawpi.Api.DTOS.Account;
using Pri.Pawpi.Api.DTOS.Account.Request;
using Pri.Pawpi.Core.Services.Models.Consultations;
using Pri.Pawpi.Core.Services.Models.Customer;
using Pri.Pawpi.Core.Services.Models.Medication;
using Pri.Pawpi.Core.Services.Models.Pet;
using Pri.Pawpi.Core.Services.Models.Practice;
using Pri.Pawpi.Core.Services.Models.Specialty;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Api.Extensions
{
    public static class ModelMapperExtensionMethod
    {
        #region specialty model mapper
        public static SpecialtyAddModel MapModel(this SpecialtyCreateDto specialtyCreateDto)
        {
            return new SpecialtyAddModel
            {
                Name = specialtyCreateDto.Name,
                Description = specialtyCreateDto.Description,
                VeterinarianIds = specialtyCreateDto.Veterinarians
            };
        }

        public static SpecialtyUpdateModel MapModel(this SpecialtyUpdateDto specialtyUpdateDto)
        {
            return new SpecialtyUpdateModel
            {
                Id = specialtyUpdateDto.Id,
                Name = specialtyUpdateDto.Name,
                Description = specialtyUpdateDto.Description,
                VeterinarianIds = specialtyUpdateDto.Veterinarians
            };
        }
        #endregion

        #region medication model mapper
        public static MedicationAddModel MapModel(this MedicationCreateDto medicationCreateDto)
        {
            return new MedicationAddModel
            {
                Name = medicationCreateDto.Name,
                Notes = medicationCreateDto.Notes,
                SideEffects = medicationCreateDto.SideEffects,
                PetIds = medicationCreateDto.Pets,
                Dosage = medicationCreateDto.Dosage,
                Frequency = medicationCreateDto.Frequency
            };
        }

        public static MedicationUpdateModel MapModel(this MedicationUpdateDto medicationUpdateDto)
        {
            return new MedicationUpdateModel
            {
                Id = medicationUpdateDto.Id,
                Name = medicationUpdateDto.Name,
                Notes = medicationUpdateDto.Notes,
                SideEffects = medicationUpdateDto.SideEffects,
                PetIds = medicationUpdateDto.Pets,
                Dosage = medicationUpdateDto.Dosage,
                Frequency = medicationUpdateDto.Frequency
            };
        }
        #endregion

        #region veterinarian model mapper
        public static VeterinarianAddModel MapModel(this VeterinarianCreateDto veterinarianCreateDto)
        {
            return new VeterinarianAddModel
            {
                FirstName = veterinarianCreateDto.FirstName,
                LastName = veterinarianCreateDto.LastName,
                Birth = veterinarianCreateDto.Birth,
                Address = veterinarianCreateDto.Address,
                City = veterinarianCreateDto.City,
                Email = veterinarianCreateDto.Email,
                Phone = veterinarianCreateDto.Phone,
                Postal = veterinarianCreateDto.Postal,
                Image = veterinarianCreateDto.Image,
                SpecialtyIds = veterinarianCreateDto.Specialties,
                ConsultationIds = veterinarianCreateDto.Consultations,
                PracticeIds = veterinarianCreateDto.Practices
            };
        }

        public static VeterinarianUpdateModel MapModel(this VeterinarianUpdateDto veterinarianUpdateDto)
        {
            return new VeterinarianUpdateModel
            {
                Id = veterinarianUpdateDto.Id,
                FirstName = veterinarianUpdateDto.FirstName,
                LastName = veterinarianUpdateDto.LastName,
                Birth = veterinarianUpdateDto.Birth,
                Address = veterinarianUpdateDto.Address,
                City = veterinarianUpdateDto.City,
                Email = veterinarianUpdateDto.Email,
                Phone = veterinarianUpdateDto.Phone,
                Postal = veterinarianUpdateDto.Postal,
                Image = veterinarianUpdateDto.Image,
                SpecialtyIds = veterinarianUpdateDto.Specialties,
                ConsultationIds = veterinarianUpdateDto.Consultations,
                PracticeIds = veterinarianUpdateDto.Practices
            };
        }
        #endregion

        #region customer model mapper
        public static CustomerAddModel MapModel(this CustomerCreateDto customerCreateDto)
        {
            return new CustomerAddModel
            {
                FirstName = customerCreateDto.FirstName,
                LastName = customerCreateDto.LastName,
                Birth = customerCreateDto.Birth,
                Address = customerCreateDto.Address,
                City = customerCreateDto.City,
                Email = customerCreateDto.Email,
                Phone = customerCreateDto.Phone,
                Postal = customerCreateDto.Postal,
                PracticeId = customerCreateDto.PracticeId,
                PetIds = customerCreateDto.Pets
            };
        }

        public static CustomerUpdateModel MapModel(this CustomerUpdateDto customerUpdateDto)
        {
            return new CustomerUpdateModel
            {
                Id = customerUpdateDto.Id,
                FirstName = customerUpdateDto.FirstName,
                LastName = customerUpdateDto.LastName,
                Birth = customerUpdateDto.Birth,
                Address = customerUpdateDto.Address,
                City = customerUpdateDto.City,
                Email = customerUpdateDto.Email,
                Phone = customerUpdateDto.Phone,
                Postal = customerUpdateDto.Postal,
                PracticeId = customerUpdateDto.PracticeId,
                PetIds = customerUpdateDto.Pets
            };
        }
        #endregion

        #region consultation model mapper
        public static ConsultationAddModel MapModel(this ConsultationCreateDto consultationCreateDto)
        {
            return new ConsultationAddModel
            {
                Title = consultationCreateDto.Title,
                Diagnosis = consultationCreateDto.Diagnosis,
                Treatment = consultationCreateDto.Treatment,
                Notes = consultationCreateDto.Notes,
                DateOfConsultation = consultationCreateDto.DateOfConsultation,
                Image = consultationCreateDto.Image,
                Document = consultationCreateDto.Document,
                VeterinarianId = consultationCreateDto.Veterinarian,
                PetId = consultationCreateDto.Pet
            };
        }

        public static ConsultationUpdateModel MapModel(this ConsultationUpdateDto consultationUpdateDto)
        {
            return new ConsultationUpdateModel
            {
                Id = consultationUpdateDto.Id,
                Title = consultationUpdateDto.Title,
                Diagnosis = consultationUpdateDto.Diagnosis,
                Treatment = consultationUpdateDto.Treatment,
                Notes = consultationUpdateDto.Notes,
                DateOfConsultation = consultationUpdateDto.DateOfConsultation,
                Image = consultationUpdateDto.Image,
                Document = consultationUpdateDto.Document,
                VeterinarianId = consultationUpdateDto.Veterinarian,
                PetId = consultationUpdateDto.Pet
            };
        }
        #endregion

        #region pet model mapper
        public static PetAddModel MapModel(this PetCreateDto petCreateDto)
        {
            return new PetAddModel
            {
                Name = petCreateDto.Name,
                CallName = petCreateDto.CallName,
                Breed = petCreateDto.Breed,
                Color = petCreateDto.Color,
                AnimalType = petCreateDto.AnimalType,
                Weight = petCreateDto.Weight,
                Image = petCreateDto.Image,
                Pedigree = petCreateDto.Pedigree,
                ConsultationIds = petCreateDto.Consultations,
                MedicationIds = petCreateDto.Medicine,
                CustomerId = petCreateDto.Customer
            };
        }

        public static PetUpdateModel MapModel(this PetUpdateDto petUpdateDto)
        {
            return new PetUpdateModel
            {
                Id = petUpdateDto.Id,
                Name = petUpdateDto.Name,
                CallName = petUpdateDto.CallName,
                Breed = petUpdateDto.Breed,
                Color = petUpdateDto.Color,
                AnimalType = petUpdateDto.AnimalType,
                Weight = petUpdateDto.Weight,
                Image = petUpdateDto.Image,
                Pedigree = petUpdateDto.Pedigree,
                ConsultationIds = petUpdateDto.Consultations,
                MedicationIds = petUpdateDto.Medicine,
                CustomerId = petUpdateDto.Customer
            };
        }
        #endregion

        #region practice model mapper
        public static PracticeAddModel MapModel(this PracticeCreateDto practiceCreateDto)
        {
            return new PracticeAddModel
            {
                Name = practiceCreateDto.Name,
                Address = practiceCreateDto.Address,
                City = practiceCreateDto.City,
                Email = practiceCreateDto.Email,
                Phone = practiceCreateDto.Phone,
                Postal = practiceCreateDto.Postal,
                OpenTime = practiceCreateDto.OpenTime,
                CloseTime = practiceCreateDto.CloseTime,
                Logo = practiceCreateDto.Logo,
                CustomerIds = practiceCreateDto.Customers,
                VeterinarianIds = practiceCreateDto.Veterinarians
            };
        }

        public static PracticeUpdateModel MapModel(this PracticeUpdateDto practiceUpdateDto)
        {
            return new PracticeUpdateModel
            {
                Id = practiceUpdateDto.Id,
                Name = practiceUpdateDto.Name,
                Address = practiceUpdateDto.Address,
                City = practiceUpdateDto.City,
                Email = practiceUpdateDto.Email,
                Phone = practiceUpdateDto.Phone,
                Postal = practiceUpdateDto.Postal,
                OpenTime = practiceUpdateDto.OpenTime,
                CloseTime = practiceUpdateDto.CloseTime,
                Logo = practiceUpdateDto.Logo,
                CustomerIds = practiceUpdateDto.Customers,
                VeterinarianIds = practiceUpdateDto.Veterinarians
            };
        }
        #endregion
    }
}
