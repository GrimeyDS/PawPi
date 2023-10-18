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
            return vets.Select(v => new VeterinarianResponseDto
            {
                Id = v.Id,
                FirstName = v.FirstName,
                LastName = v.LastName,
                Birth = v.Birth,
                Address = v.Address,
                City = v.City,
                Email = v.Email,
                Phone = v.Phone,
                Postal = v.Postal
            });
        }
        #endregion

        #region specialty dto mapper
        public static IEnumerable<SpecialtyResponseDto> MapSpecialtiesDto(this IEnumerable<Specialty> specs)
        {
            return specs.Select(s => new SpecialtyResponseDto
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Veterinarians = s.Veterinarians.MapVeterinariansDto()
            });
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
        public static IEnumerable<MedicationResponseDto> MapMediceneDto(this IEnumerable<Medication> meds)
        {
            return meds.Select(m => new MedicationResponseDto
            {
                Id = m.Id,
                Name = m.Name,
                Notes = m.Notes,
                SideEffects = m.SideEffects
            });
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
