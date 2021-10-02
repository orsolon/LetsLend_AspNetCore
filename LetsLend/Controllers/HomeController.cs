using LetsLend.Models;
using LetsLend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LetsLend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryItem _repositoryItem;
        private readonly IUserRepository _repositoryUser;
        private readonly IBorrowedItemsRepository _repositoryBorrowedItems;
        

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

        public IActionResult ToBorrowItem(int id)
        {
            var emprestando = _repositoryBorrowedItems.BorrowedItems.FirstOrDefault(borrowedItem => borrowedItem.Id == id);

            if (emprestando == null)
                return RedirectToAction("Item");

            return View(emprestando);
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
            var viewModel = new BorrowerViewModel()
            {
                Borrowers = _repositoryUser.Users
            };
            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var editando = _repositoryUser.Users.FirstOrDefault(users => users.Id == id);

            if (editando == null)
                return RedirectToAction("Borrower");

            return View(editando);
        }

        [HttpPost]
        public IActionResult Edit(Borrower borrower)
        {
            _repositoryUser.UpdateBorrower(borrower);

            return RedirectToAction("Borrower");
        }

        public IActionResult Remove(int id)
        {
            var removendo = _repositoryUser.Users.FirstOrDefault(users => users.Id == id);

            if (removendo == null)
                return RedirectToAction("Borrower");

            return View(removendo);
        }

        [HttpPost]
        public IActionResult Remove(Borrower borrower)
        {
            _repositoryUser.RemoveBorrower(borrower);

            return RedirectToAction("Borrower");
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
                return RedirectToAction("Borrower");
            }

            return View(user);
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}