using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApplicationForVR.Models;

namespace TestApplicationForVR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly string fileRoote = "massageStorage.xml";

        private readonly MassageStorageFileManager _messageStorageFileManager;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _messageStorageFileManager = new MassageStorageFileManager();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SetMassage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetMassage(string userName, string massageText)
        {
           MassageStorageService _massageStorage = _messageStorageFileManager.Get(fileRoote);
            if(_massageStorage == null)
            {
                _massageStorage = new MassageStorageService();
            }
            _massageStorage.AddMassage(userName, massageText);
            _messageStorageFileManager.Set(_massageStorage, "massageStorage.xml");

            return Redirect("/home/SetMassage");
        }

        [HttpGet]
        public IActionResult GetMassages()
        {
            MassageStorageService _massageStorage = _messageStorageFileManager.Get(fileRoote);
            var vm = _massageStorage.GetMassages();
            return View(vm);
        }

        public IActionResult GetMassagesSortedById()
        {
            MassageStorageService _massageStorage = _messageStorageFileManager.Get(fileRoote);
            var vm = _massageStorage.GetMassages().OrderBy(item => item.UserId);
            return View(vm);
        }

        public IActionResult GetMassagesSortedByDate()
        {
            MassageStorageService _massageStorage = _messageStorageFileManager.Get(fileRoote);
            var vm = _massageStorage.GetMassages().OrderBy(item => item.TimeOfCreation);
            return View(vm);
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
