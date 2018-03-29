using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.DataAccess.Interfaces;

namespace Test.DataAccess.DAL
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly DbContext _dataContext;
        protected readonly DbSet<T> _dataSet;

        public Repository(DbContext dataContext)
        {
            _dataContext = dataContext;
            _dataSet = dataContext.Set<T>();
        }

        public IQueryable<T> Query()
        {
            return _dataSet;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<T> GetByIDAsync(int id)
        {
            return await _dataSet.FirstOrDefaultAsync(x => x.ID == id);
        }

        public void Delete(T entity)
        {
            _dataSet.Remove(entity);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
