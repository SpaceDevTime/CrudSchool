using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);


        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);

    }
}
