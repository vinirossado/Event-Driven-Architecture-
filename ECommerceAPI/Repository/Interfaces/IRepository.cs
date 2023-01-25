namespace ECommerce.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(Guid guid);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}
