using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Services
{
    public class VeterinarianService : ServiceBase<Veterinarian>, IVeterinarianService
    {
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly IConsultationRepository _consultationRepository;

        public VeterinarianService(IVeterinarianRepository veterinarianRepository, ISpecialtyRepository specialtyRepository, IConsultationRepository consultationRepository) : base(veterinarianRepository)
        {
            _specialtyRepository = specialtyRepository;
            _consultationRepository = consultationRepository;
        }

        public async Task<ResultModel<Veterinarian>> SearchByNameAsync(string name)
        {
            var vets = await _repository.SearchByNameAsync(name);

            if (vets.Count() == 0)
                return vets.ToErrorModel("No veterinarians found");

            return vets.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> GetSpecialtiesFromVeterinariansAsync(int id)
        {
            var specialties = await _specialtyRepository.GetAllAsync();

            var specialtiesByVets = specialties.Where(s => s.Veterinarians.Any(v => v.Id == id));

            if (specialtiesByVets.Count() == 0)
                return specialtiesByVets.ToErrorModel("No specialties found");

            return specialtiesByVets.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> GetConsultationsFromVeterinariansAsync(int id)
        {
            var consultations = await _consultationRepository.GetAllAsync();

            var consultationsByVets = consultations.Where(c => c.VeterinarianId.Equals(id));

            if (consultationsByVets.Count() == 0)
                return consultationsByVets.ToErrorModel("No consultations found");

            return consultationsByVets.ToResultModel();
        }

        public Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
