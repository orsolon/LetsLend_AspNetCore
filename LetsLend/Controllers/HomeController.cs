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
        

        public HomeController(ILogger<HomeController> logger, IRepositoryItem repositoryItem, IUserRepository repositoryUser, IBorrowedItemsRepository repositoryBorrowedItems)
        {
            _logger = logger;
            _repositoryItem = repositoryItem;
            _repositoryUser = repositoryUser;
            _repositoryBorrowedItems = repositoryBorrowedItems;
        }

        public IActionResult Index()
        {
            var viewModel = new ItemViewModel()
            {
                Items = _repositoryItem.Items
            };

            return View(viewModel);
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

        public IActionResult EditItem(int id)
        {
            var editando = _repositoryItem.Items.FirstOrDefault(item => item.Id == id);

            if (editando == null)
                return RedirectToAction("Item");

            return View(editando);
        }

        [HttpPost]
        public IActionResult EditItem(Item item)
        {
            _repositoryItem.UpdateItem(item);

            return RedirectToAction("Item");
        }

        public IActionResult RemoveItem(int id)
        {
            var removendo = _repositoryItem.Items.FirstOrDefault(items => items.Id == id);

            if (removendo == null)
                return RedirectToAction("Item");

            return View(removendo);
        }

        [HttpPost]
        public IActionResult RemoveItem(Item item)
        {
            _repositoryItem.RemoveItem(item);
           
            return RedirectToAction("Item");
        }

        public IActionResult ToBorrowItem( )
        {         
            return View();       
        }

        [HttpPost]
        public IActionResult ToBorrowItem(BorrowedItems borrowedItem)
        {
            if (ModelState.IsValid)
            {
                //validação impedindo emprestar o mesmo item mais de uma vez
                _repositoryBorrowedItems.AddBorrowedItem(borrowedItem);
                var itemEmprestado = _repositoryBorrowedItems.BorrowedItems.OrderBy(s => s.Id).Last();
                var idItem = itemEmprestado.ItemId;
                var idClient = itemEmprestado.BorrowerId;
                var nomeCliente = _repositoryUser.Users.FirstOrDefault(x => x.Id == idClient).Name;

                // mudar parametro do borrowername do item
                var itemEmprestado2 = _repositoryItem.Items.FirstOrDefault(x => x.Id == idItem);
                _repositoryItem.ChangeItemBorrower(idItem, nomeCliente);

                return RedirectToAction("Item");
            }
            return View(borrowedItem);
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


        public IActionResult Reports()
        {
            var viewModelReport = new ReportsViewModel()
            {

            };

            var count = _repositoryItem.CountItem();
            ViewBag.Item = count;
            var countUser = _repositoryUser.CountUser();
            ViewBag.User = countUser;
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}