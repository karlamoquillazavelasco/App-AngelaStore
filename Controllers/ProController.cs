using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App_AngelaStore.Controllers
{
    public class ProController : Controller
    
    {
        private readonly ILogger<ProController> _logger;

        public ProController(ILogger<ProController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}