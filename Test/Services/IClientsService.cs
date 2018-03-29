using System.Collections.Generic;
using System.Threading.Tasks;
using Test.DTO;

namespace Test.Services
{
    public interface IClientsService
    {
        Task<IEnumerable<ClientDTO>> GetAllClients();
    }
}
