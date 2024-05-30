namespace data_graph_designer.Interfaces
{
    public interface ICrudRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllPaginated(int page, int pageSize);
        Task<T> GetById(int id);
        Task<T> Save(T entity);
        Task<T> Update(T entity);
        Task<bool> DeleteById(int id);
    }
}
