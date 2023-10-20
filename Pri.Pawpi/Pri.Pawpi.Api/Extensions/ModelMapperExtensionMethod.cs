using Pri.Pawpi.Api.Dtos.Medication.Request;
using Pri.Pawpi.Api.Dtos.Specialty.Request;
using Pri.Pawpi.Core.Services.Models.Medication;
using Pri.Pawpi.Core.Services.Models.Specialty;

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
    }
}
