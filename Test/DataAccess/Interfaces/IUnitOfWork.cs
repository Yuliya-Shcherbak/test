using System.Threading.Tasks;

namespace Test.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class, IEntity;
        Task SaveAsync();
    }
}
