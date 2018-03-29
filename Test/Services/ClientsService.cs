using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DataAccess.Entities;
using Test.DataAccess.Interfaces;
using Test.DTO;

namespace Test.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ClientDTO GetbyID(int ID)
        {

            return null;
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClients()
        {
            using (var clientRepository = _unitOfWork.Repository<ClientModel>())
            {
                var clients = await clientRepository.Query().Select(m => new ClientDTO
                {
                    ID = m.ID,
                    Address = m.Address,
                    FirstName = m.FirstName,
                    LastName = m.LastName,
                    Phones = m.Phone
                }).ToListAsync();
                return clients;
            }
        }

        public IEnumerable<TaskDTO> GetClientTasks(int ID)
        {
            return null;
        }
    }
}
