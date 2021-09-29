using LetsLend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace LetsLend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        public IActionResult Borrower()
        {
            return View();
        }

        public ViewResult Reports()
        {
            return View();
        }

        public IActionResult UserRegister()
        {

            return View();
        }

        public IActionResult ItemRegister()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ItemRegister(Item item)
        {

            if (ModelState.IsValid)
            {
                ItemRepository.AddItem(item);
                return RedirectToAction("Item");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult UserRegister(Borrower user)
        {
            if (ModelState.IsValid)
            {
                UserRepository.AddUser(user);
                return View();
            }
           
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
