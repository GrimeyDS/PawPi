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
        private readonly IPracticeRepository _practiceRepository;

        public VeterinarianService(IVeterinarianRepository veterinarianRepository, 
            ISpecialtyRepository specialtyRepository, 
            IConsultationRepository consultationRepository,
            IPracticeRepository practiceRepository) : base(veterinarianRepository)
        {
            _specialtyRepository = specialtyRepository;
            _consultationRepository = consultationRepository;
            _practiceRepository = practiceRepository;
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

        public async Task<ResultModel<Practice>> GetPracticesFromVeterinariansAsync(int id)
        {
            var practices = await _practiceRepository.GetAllAsync();

            var practicesByVet = practices.Where(s => s.Veterinarians.Any(v => v.Id == id));

            if (practicesByVet.Count() == 0)
                return practicesByVet.ToErrorModel("No practices found");

            return practicesByVet.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel)
        {
            var vets = _repository.GetAll();

            var specialties = _specialtyRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var practices = _practiceRepository.GetAll();
            
            var modelSpecialtyIds = addModel.SpecialtyIds;
            var modelConsultationIds = addModel.ConsultationIds;
            var modelPracticeIds = addModel.PracticeIds;

            var veterinarianToAdd = new Veterinarian();

            // Input checks
            if (!specialties.CheckIfIdsExist(modelSpecialtyIds))
                return veterinarianToAdd.ToErrorModel("Unknown specialties!");
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return veterinarianToAdd.ToErrorModel("Unknown consultations!");
            if (!practices.CheckIfIdsExist(modelPracticeIds))
                return veterinarianToAdd.ToErrorModel("Unknown practices!");

            if (!specialties.CheckIdsInput(modelSpecialtyIds))
                return veterinarianToAdd.ToErrorModel("Please provide a specialty");
            if (!practices.CheckIdsInput(modelPracticeIds))
                return veterinarianToAdd.ToErrorModel("Please provide a practice");

            if (vets.Any(m => m.FirstName.ToUpper().Equals(addModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(addModel.LastName.ToUpper())))
                return veterinarianToAdd.ToErrorModel("Name already exists");

            if (addModel.Birth >= DateTime.Now)
                return veterinarianToAdd.ToErrorModel("Birth date cannot be in the future");

            // Get ids to attach as entities
            var specialtiesToLink = specialties.Where(v => modelSpecialtyIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(v => modelConsultationIds.Contains(v.Id)).ToList();
            var practicesToLink = practices.Where(v => modelPracticeIds.Contains(v.Id)).ToList();

            // Update new specialty entity
            veterinarianToAdd.FirstName = addModel.FirstName;
            veterinarianToAdd.LastName = addModel.LastName;
            veterinarianToAdd.Birth = addModel.Birth;
            veterinarianToAdd.Address = addModel.Address;
            veterinarianToAdd.City = addModel.City;
            veterinarianToAdd.Postal = addModel.Postal;
            veterinarianToAdd.Phone = addModel.Phone;
            veterinarianToAdd.Email = addModel.Email;
            veterinarianToAdd.Specialties = specialtiesToLink;
            veterinarianToAdd.Consultations = consultationsToLink;
            veterinarianToAdd.Practices = practicesToLink;


            if (!await _repository.CreateAsync(veterinarianToAdd))
                return veterinarianToAdd.ToErrorModel("Something went wrong while adding veterinarian");

            return veterinarianToAdd.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel)
        {
            var vets = _repository.GetAll();

            var specialties = _specialtyRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelSpecialtyIds = updateModel.SpecialtyIds;
            var modelConsultationIds = updateModel.ConsultationIds;
            var modelPracticeIds = updateModel.PracticeIds;

            var veterinarianToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (veterinarianToUpdate == null)
                return veterinarianToUpdate.ToErrorModel("Veterinarian not found");

            // Input checks
            if (!specialties.CheckIfIdsExist(modelSpecialtyIds))
                return veterinarianToUpdate.ToErrorModel("Unknown specialties!");
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return veterinarianToUpdate.ToErrorModel("Unknown consultations!");
            if (!practices.CheckIfIdsExist(modelPracticeIds))
                return veterinarianToUpdate.ToErrorModel("Unknown practices!");

            if (!specialties.CheckIdsInput(modelSpecialtyIds))
                return veterinarianToUpdate.ToErrorModel("Please provide a specialty");
            if (!practices.CheckIdsInput(modelPracticeIds))
                return veterinarianToUpdate.ToErrorModel("Please provide a practice");

            if (updateModel.Birth >= DateTime.Now)
                return veterinarianToUpdate.ToErrorModel("Birth date cannot be in the future");

            if (veterinarianToUpdate.FirstName.ToUpper() != updateModel.FirstName.ToUpper() && 
                veterinarianToUpdate.LastName.ToUpper() != updateModel.LastName.ToUpper())
            {
                if (vets.Any(m => m.FirstName.ToUpper().Equals(updateModel.FirstName.ToUpper())
                    && m.LastName.ToUpper().Equals(updateModel.LastName.ToUpper())))
                    return veterinarianToUpdate.ToErrorModel("Name already exists");
            }

            // Get ids to attach as entities
            var specialtiesToLink = specialties.Where(v => modelSpecialtyIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(v => modelConsultationIds.Contains(v.Id)).ToList();
            var practicesToLink = practices.Where(v => modelPracticeIds.Contains(v.Id)).ToList();



            // Update specialty entity
            veterinarianToUpdate.FirstName = updateModel.FirstName;
            veterinarianToUpdate.LastName = updateModel.LastName;
            veterinarianToUpdate.Birth = updateModel.Birth;
            veterinarianToUpdate.Address = updateModel.Address;
            veterinarianToUpdate.City = updateModel.City;
            veterinarianToUpdate.Postal = updateModel.Postal;
            veterinarianToUpdate.Phone = updateModel.Phone;
            veterinarianToUpdate.Email = updateModel.Email;
            veterinarianToUpdate.Specialties.AddRange(specialtiesToLink);
            veterinarianToUpdate.Consultations.AddRange(consultationsToLink);
            veterinarianToUpdate.Practices.AddRange(practicesToLink);


            if (!await _repository.UpdateAsync(veterinarianToUpdate))
                return veterinarianToUpdate.ToErrorModel("Something went wrong while updating veterinarian");

            return veterinarianToUpdate.ToResultModel();
        }
    }
}
