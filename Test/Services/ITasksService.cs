using System.Collections.Generic;
using System.Threading.Tasks;
using Test.DTO;

namespace Test.Services
{
    public interface ITasksService
    {
        Task<IEnumerable<TaskDTO>> GetAllClientTasks(int ID);
        Task<bool> DeleteTask(int ID);
    }
}
