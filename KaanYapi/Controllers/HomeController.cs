using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KaanYapi.Models;
using KaanYapi.Data;
using KaanYapi.Repository;
using KaanYapi.Repository.IRepository;

namespace KaanYapi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogRepository _blog;

        public HomeController(ILogger<HomeController> logger, IBlogRepository blog)
        {
            _logger = logger;
            _blog = blog;
        }
        
        public IActionResult Index()
        {
           var a = _blog.GetAsync(1);

            return View(a);
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
