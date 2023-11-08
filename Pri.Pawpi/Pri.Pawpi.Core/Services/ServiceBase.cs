using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected readonly IBaseRepository<T> _repository;
        private readonly string _nameOfEntity = typeof(T).Name;

        public ServiceBase(IBaseRepository<T> repository) 
        { 
            _repository = repository;
        }

        public async Task<ResultModel<T>> DeleteAsync(int id)
        {
            var entityToDelete = await _repository.GetByIdAsync(id);

            if (entityToDelete == null)
                return entityToDelete.ToErrorModel($"{_nameOfEntity} {Constants.NotFoundMessage}");

            if (!await _repository.DeleteAsync(entityToDelete))
                return entityToDelete.ToErrorModel($"{Constants.DBDeleteMessage} {_nameOfEntity}");

            return entityToDelete.ToResultModel();
        }

        public async Task<ResultModel<T>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities.ToResultModel();
        }

        public async Task<ResultModel<T>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity == null)
                return entity.ToErrorModel($"{_nameOfEntity} {Constants.NotFoundMessage}");

            return entity.ToResultModel();
        }
    }
}
