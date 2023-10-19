using Pri.Pawpi.Api.Dtos.Specialty.Request;
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
    }
}
