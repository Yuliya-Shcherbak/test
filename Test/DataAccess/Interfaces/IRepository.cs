using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.DataAccess.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class, IEntity
    {
        IQueryable<T> Query();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(int id);
        void Delete(T entity);
    }
}
