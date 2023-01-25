using ECommerce.Data.Context;
using ECommerce.Domain.Interface;
using ECommerce.Repository.Interfaces;

namespace ECommerce.Repository.Base
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly InvoiceDbContext InvoiceDbContext;

        public GenericRepository(InvoiceDbContext customDbContext) => InvoiceDbContext = customDbContext;

        public IEnumerable<TEntity> GetAll() => InvoiceDbContext.Set<TEntity>();

        public async Task<TEntity> GetByIdAsync(Guid guid)
        {
            return await InvoiceDbContext.Set<TEntity>().FindAsync(guid);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            await InvoiceDbContext.AddAsync(entity);
            await InvoiceDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);

            InvoiceDbContext.Update(entity);
            await InvoiceDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            var itemToRemove = await InvoiceDbContext.Set<TEntity>().FindAsync(entity.Id);
            InvoiceDbContext.Remove(itemToRemove);
            await InvoiceDbContext.SaveChangesAsync();
            return itemToRemove;
        }
    }
}