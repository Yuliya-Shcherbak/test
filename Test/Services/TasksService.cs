using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DataAccess.Entities;
using Test.DataAccess.Interfaces;
using Test.DTO;

namespace Test.Services
{
    public class TasksService : ITasksService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TasksService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TaskDTO>> GetAllClientTasks(int clientID)
        {
            using (var taskRepository = _unitOfWork.Repository<TaskModel>())
            {
                var tasks = await taskRepository.Query()
                    .Where(x => x.ClientModelID == clientID)
                    .Select(m => new TaskDTO
                    {
                        ID = m.ID,
                        Name = m.Name,
                        Address = m.Address,
                        Description = m.Description,
                        StartDate = m.StartDate,
                        EndDate = m.EndDate
                    }).ToListAsync();
                return tasks;
            }
        }

        public async Task<bool> DeleteTask(int ID)
        {
            using (var taskRepository = _unitOfWork.Repository<TaskModel>())
            {
                var task = await taskRepository.GetByIDAsync(ID);
                if (task != null)
                {
                    taskRepository.Delete(task);
                    await _unitOfWork.SaveAsync();
                    return true;
                }
                else return false;
            }
        }
    }
}