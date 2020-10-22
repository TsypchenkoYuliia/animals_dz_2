using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<IReadOnlyCollection<T>> GetAsync();
        Task AddAsync(T obj);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task UpdateAsync(T obj);
    }
}
