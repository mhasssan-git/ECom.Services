using System.Linq.Expressions;
using Common.Core;
using Common.Core.Interface;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace Common.Repository
{
    public abstract class DbRepository<TModel, TId> : IRepository<TModel, TId> where TModel : Entity<TId>
    {
        private protected DbSet<TModel> DbSet;
        private protected DbContext dbContext;

        protected DbRepository(DbContext context)
        {
            dbContext = context;
            DbSet = dbContext.Set<TModel>();
        }

        public async Task<List<TModel>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TModel?> GetEntityWithSpec(Expression<Func<TModel, bool>> spec)
        {
           return await DbSet.Where(spec).FirstOrDefaultAsync();
        }


        public async Task<TModel> GetAsync(TId id)
        {
            return await DbSet.FindAsync(id);
        }



        public async Task<TModel> CreatedAsync(TModel entity)
        {
            var result=await dbContext.AddAsync(entity);
            return result.Entity;
        }

        public TModel UpdateAsync(TModel entity)
        {
            var result =   dbContext.Update(entity);
            return result.Entity;
        }

        public async Task RemoveAsync(TId id)
        {
            var enttiiy=await GetAsync(id);
            DbSet.Remove(enttiiy);
        }
    }


}