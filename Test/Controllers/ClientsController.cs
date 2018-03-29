using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        private readonly IClientsService _clientsService;

        public ClientsController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        // GET api/clients
        [HttpGet ("getAllClients")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _clientsService.GetAllClients();

            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }
    }
}