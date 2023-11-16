using System.Linq.Expressions;


namespace Common.Core.Interface
{
    public interface IRepository<T,TId> where T : Entity<TId>
    {
        public Task<List<T>> GetAllAsync();
        Task<T?> GetEntityWithSpec(Expression<Func<T,bool>> spec);
        public Task<T> GetAsync(TId id);
   
        public Task<T> CreatedAsync(T entity);
        public T UpdateAsync(T entity);
        public Task RemoveAsync(TId id);

    }
}
