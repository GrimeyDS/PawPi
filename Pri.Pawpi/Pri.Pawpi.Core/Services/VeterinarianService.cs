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
        public VeterinarianService(IVeterinarianRepository veterinarianRepository) : base(veterinarianRepository)
        {
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
