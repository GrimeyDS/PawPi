using Pri.Pawpi.Api.Dtos.Medication.Request;
using Pri.Pawpi.Api.Dtos.Specialty.Request;
using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using Pri.Pawpi.Core.Services.Models.Customer;
using Pri.Pawpi.Core.Services.Models.Medication;
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
                VeterinarianIds = specialtyCreateDto.VeterinarianIds
            };
        }

        public static SpecialtyUpdateModel MapModel(this SpecialtyUpdateDto specialtyUpdateDto)
        {
            return new SpecialtyUpdateModel
            {
                Id = specialtyUpdateDto.Id,
                Name = specialtyUpdateDto.Name,
                Description = specialtyUpdateDto.Description,
                VeterinarianIds = specialtyUpdateDto.VeterinarianIds
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
                PetIds = medicationCreateDto.PetIds,
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
                PetIds = medicationUpdateDto.PetIds,
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
                SpecialtyIds = veterinarianCreateDto.SpecialtyIds,
                ConsultationIds = veterinarianCreateDto.ConsultationIds,
                PracticeIds = veterinarianCreateDto.PracticeIds
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
                SpecialtyIds = veterinarianUpdateDto.SpecialtyIds,
                ConsultationIds = veterinarianUpdateDto.ConsultationIds,
                PracticeIds = veterinarianUpdateDto.PracticeIds
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
                PetIds = customerCreateDto.PetIds
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
                PetIds = customerUpdateDto.PetIds
            };
        }
        #endregion
    }
}
