using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Test.DataAccess.Interfaces;
using Test.DataAccess.EFContext;

namespace Test.DataAccess.DAL
{
    public class UnitOfWork : IUnitOfWork
    {        
        private readonly DBContext _dataContext;

        public UnitOfWork(DBContext _context)
        {
            _dataContext = _context;
        }

        public IRepository<T> Repository<T>() where T : class, IEntity
        {
            return new Repository<T>(_dataContext);
        }

        public async Task SaveAsync()
        {
            await _dataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}

