using Pri.Pawpi.Api.Dtos.Medication;
using Pri.Pawpi.Api.Dtos.Specialty;
using Pri.Pawpi.Api.Dtos.Veterinarian;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Api.Extensions
{
    public static class DtoMapperExtensionMethod
    {

        #region veterinarian dto mapper
        public static IEnumerable<VeterinarianResponseDto> MapVeterinariansDto(this IEnumerable<Veterinarian> vets)
        {
            return vets.Select(v => v.MapVeterinarianDto());
        }

        public static VeterinarianResponseDto MapVeterinarianDto(this Veterinarian vet)
        {
            return new VeterinarianResponseDto
            {
                Id = vet.Id,
                FirstName = vet.FirstName,
                LastName = vet.LastName,
                Birth = vet.Birth,
                Address = vet.Address,
                City = vet.City,
                Email = vet.Email,
                Phone = vet.Phone,
                Postal = vet.Postal,
                Specialties = vet.Specialties.MapSpecialtiesDto(),
                //Practices = vet.Practices.MapPracticesDto()
            };
        }
        #endregion

        #region specialty dto mapper
        public static IEnumerable<SpecialtyResponseDto> MapSpecialtiesDto(this IEnumerable<Specialty> specs)
        {
            return specs.Select(s => s.MapSpecialtyDto());
        }

        public static SpecialtyResponseDto MapSpecialtyDto(this Specialty spec)
        {
            return new SpecialtyResponseDto
            {
                Id = spec.Id,
                Name = spec.Name,
                Description = spec.Description,
                Veterinarians = spec.Veterinarians.MapVeterinariansDto()
            };
        }
        #endregion


        #region medication dto mapper
        public static IEnumerable<MedicationResponseDto> MapMedicineDto(this IEnumerable<Medication> meds)
        {
            return meds.Select(m => m.MapMedicationDto());
        }

        public static MedicationResponseDto MapMedicationDto(this Medication med)
        {
            return new MedicationResponseDto
            {
                Id = med.Id,
                Name = med.Name,
                Notes = med.Notes,
                SideEffects = med.SideEffects
            };
        }
        #endregion
    }
}
