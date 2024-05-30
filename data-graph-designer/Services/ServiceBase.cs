using data_graph_designer.Interfaces;
using data_graph_designer.Repository;
using NuGet.Protocol.Core.Types;

namespace data_graph_designer.Services
{
    public class ServiceBase<U> : IService<U> where U : class
    {
        protected readonly CrudBaseRepository<U> _repository;
        public ServiceBase(CrudBaseRepository<U> repository)
        {
            this._repository = repository;
        }

        public Task<bool> DeleteById(int id)
        {
            return _repository.DeleteById(id);
        }

        public Task<IEnumerable<U>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IEnumerable<U>> GetAllPaginated(int page, int pageSize)
        {
            return _repository.GetAllPaginated(page, pageSize);
        }

        public Task<U> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task<U> Save(U entity)
        {
            return _repository.Save(entity);
        }

        public Task<U> Update(U entity, int id)
        {
            return _repository.Update(entity);
        }
    }
}
