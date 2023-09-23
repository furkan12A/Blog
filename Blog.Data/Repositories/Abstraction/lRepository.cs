using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Data.Repositories.Abstraction
{
    public interface lRepository<T> where T : class, lEntityBase,new()
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, Object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, Object>>[] includeProperties);
        Task<T> GetByGuidAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate); 
        Task<int> CountAsync(Expression<Func<T, bool>> predicate =null);



        
    }
}
