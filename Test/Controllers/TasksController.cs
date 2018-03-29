using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private ITasksService _taskService;

        public TasksController(ITasksService taskService)
        {
            _taskService = taskService;
        }

        // GET: api/Groups/5
        [HttpGet ("getClientTasks/{id}")]
        public async Task<IActionResult> GetClientTasks(int id)
        {
            var tasks = await _taskService.GetAllClientTasks(id);

            if (tasks == null)
            {
                return NotFound();
            }
            return Ok(tasks);
        }

        [HttpDelete ("deleteTask/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            bool result = await _taskService.DeleteTask(id);

            if (result == false)
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }
            return Ok();
        }
    }
}