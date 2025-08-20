using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CuttingDownIncidents.Data
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
        Task<IEnumerable<T>> GetByCategoryIdAsync(int categoryId);
        Task SoftDeleteAsync(int id);
        
    }
}
