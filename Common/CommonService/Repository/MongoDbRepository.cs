using System.Linq.Expressions;
using Common.Core;
using Common.Core.Interface;
using MongoDB.Driver;

namespace Common.Repository
{
    public class MongoDbRepository<TModel, TId> : IMongoDbRepository<TModel, TId> where TModel : Entity<TId>
    {
        private readonly IMongoCollection<TModel> _dbCollection;
        private readonly FilterDefinitionBuilder<TModel> _filterBuilder = Builders<TModel>.Filter;

        public MongoDbRepository(IMongoDatabase database, string collectionName)
        {
            _dbCollection = database.GetCollection<TModel>(collectionName);
        }

        public async Task<IReadOnlyCollection<TModel>> GetAllAsync()
        {
            return await _dbCollection.Find(FilterDefinition<TModel>.Empty).ToListAsync();
        }

        public async Task<IReadOnlyCollection<TModel>> GetAllAsync(Expression<Func<TModel, bool>> filter)
        {
            return await _dbCollection.Find(filter).ToListAsync();
        }

        public async Task<TModel> GetAsync(TId id)
        {
            FilterDefinition<TModel> filter = _filterBuilder.Eq<TId>(a => a.Id, id);
            return await _dbCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<TModel> GetAsync(Expression<Func<TModel, bool>> filter)
        {
            return await _dbCollection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task CreatedAsync(TModel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            await _dbCollection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(TModel entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            FilterDefinition<TModel> filter = _filterBuilder.Eq<TId>(a => a.Id, entity.Id);
            await _dbCollection.ReplaceOneAsync(filter
                , entity);
        }

        public async Task RemoveAsync(TId id)
        {
            FilterDefinition<TModel> filter = _filterBuilder.Eq<TId>(a => a.Id, id);
            await _dbCollection.DeleteOneAsync(filter);
        }

    }
}
