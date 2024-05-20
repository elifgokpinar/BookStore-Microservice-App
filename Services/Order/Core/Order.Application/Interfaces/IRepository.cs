
using System.Linq.Expressions;

namespace Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByIdAsync(int id);
        Task<List<T>> CreateAsync(T entity);
        Task<List<T>> UpdateAsync(T entity);
        Task<List<T>> DeleteAsync(T entity);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);

    }
}
