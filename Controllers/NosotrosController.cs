using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App_AngelaStore.Models;

namespace App_AngelaStore.Controllers
{
    public class NosotrosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public NosotrosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
