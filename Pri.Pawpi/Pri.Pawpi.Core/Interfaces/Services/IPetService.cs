using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Pet;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IPetService : IServiceBase<Pet>
    {
        Task<ResultModel<Pet>> AddAsync(PetAddModel addModel);
        Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel);
        Task<ResultModel<Pet>> SearchByNameAsync(string name);
        Task<ResultModel<Pet>> SearchByAnimalTypeAsync(string animalType);
        Task<ResultModel<Pet>> SearchByBreedAsync(string breed);
        Task<ResultModel<Medication>> GetMedicineFromPetAsync(int id);
        Task<ResultModel<Consultation>> GetConsultationsFromPetAsync(int id);
    }
}
