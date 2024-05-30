namespace data_graph_designer.Interfaces
{
    public interface IService<T>{
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllPaginated(int page, int pageSize);
        Task<T> GetById(int id);
        Task<T> Save(T entity);
        Task<T> Update(T entity, int id);
        Task<bool> DeleteById(int id);
    }
}