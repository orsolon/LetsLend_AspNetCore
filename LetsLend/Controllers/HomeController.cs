using LetsLend.Models;
using LetsLend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace LetsLend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryItem _repositoryItem;
        private readonly IUserRepository _repositoryUser;

        public HomeController(ILogger<HomeController> logger, IRepositoryItem repositoryItem, IUserRepository repositoryUser)
        {
            _logger = logger;
            _repositoryItem = repositoryItem;
            _repositoryUser = repositoryUser;


        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item()
        {
            var viewModel = new ItemViewModel()
            {
                Items = _repositoryItem.Items
        };

            return View(viewModel);
        }

        public IActionResult ItemRegister()
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
                _repositoryItem.AddItem(item);
                return RedirectToAction("Item");
            }
            return View(item);
        }


        public IActionResult RemoveItem(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult RemoveItem(Item item)
        {
            _repositoryItem.RemoveItem(item);
           
            return RedirectToAction("Item");
           
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
                _repositoryUser.AddBorrower(user);
                return View();
            }

            return View();
        }

        public IActionResult Edit(Borrower user)
        {

            
            return View();

        }
        [HttpPost]
        public IActionResult Edit()
        {
            

            return RedirectToAction();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}