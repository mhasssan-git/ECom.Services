using System.Linq.Expressions;


namespace Common.Core.Interface
{
    public interface IMongoDbRepository<T,TId> where T : Entity<TId>
    {
        public Task<IReadOnlyCollection<T>> GetAllAsync();
        public Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        public Task<T> GetAsync(TId id);
        public Task<T> GetAsync(Expression<Func<T, bool>> filter);
        public Task CreatedAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task RemoveAsync(TId id);
    }
}
