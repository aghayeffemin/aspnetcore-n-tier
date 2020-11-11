using aspnetcore_n_tier.DAL.DataContext;
using aspnetcore_n_tier.DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore_n_tier.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly AspNetCoreNTierDbContext _aspNetCoreNTierDbContext;
        public GenericRepository(AspNetCoreNTierDbContext aspNetCoreNTierDbContext)
        {
            _aspNetCoreNTierDbContext = aspNetCoreNTierDbContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            var addedEntry = await _aspNetCoreNTierDbContext.AddAsync(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRange(List<TEntity> entity)
        {
            await _aspNetCoreNTierDbContext.AddRangeAsync(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(TEntity entity)
        {
            var addedEntry = _aspNetCoreNTierDbContext.Remove(entity);
            return await _aspNetCoreNTierDbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _aspNetCoreNTierDbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return await (filter == null ? _aspNetCoreNTierDbContext.Set<TEntity>().ToListAsync() : _aspNetCoreNTierDbContext.Set<TEntity>().Where(filter).ToListAsync());
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var addedEntry = _aspNetCoreNTierDbContext.Update(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entity)
        {
            _aspNetCoreNTierDbContext.UpdateRange(entity);
            await _aspNetCoreNTierDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
