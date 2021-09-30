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

        public IActionResult Edit(Borrower user) 
        { 

            var editing = _repositorio.UserRepository.FirstOrDefault(x => x.User == user);
            if (editing == null)
                return NotFound();

            return View(editing);
        
        }
        [HttpPost]
        public IActionResult Edit(Users users)
        {
            _repositorio.Update(users);

            return RedirectToAction("Usuários");
        }


        public IActionResult Remove(Borrower user)
        {
            var removing = _repositorio.UserRepository.FirstOrDefault(x => x.User == user);
            if (removing == null)
                return RedirectToAction("Usuários");

            return View(removing);
        }

        [HttpPost]
        public IActionResult Remove(Users users)
        {
            _repositorio.Remove(users);

            return RedirectToAction("Usuários");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
