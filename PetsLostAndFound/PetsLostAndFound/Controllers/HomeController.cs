using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PetsLostAndFound.Models;

namespace PetsLostAndFound.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<StorageAccountOptions> _optionsAccessor;

        public HomeController(ILogger<HomeController> logger, IOptions<StorageAccountOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsAccessor = optionsAccessor;
            //blobUtility = new Home.BlobUtility
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
