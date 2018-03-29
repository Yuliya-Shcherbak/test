using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Services;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private IClientsService _clientService;

        public HomeController(IClientsService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            _clientService.GetAllClients();
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
