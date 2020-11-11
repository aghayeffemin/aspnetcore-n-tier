using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore_n_tier.DAL.Repositories.IRepositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<int> Delete(T entity);
        Task<List<T>> AddRange(List<T> entity);
        Task<List<T>> UpdateRange(List<T> entity);
    }
}
