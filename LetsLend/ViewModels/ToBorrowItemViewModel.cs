using LetsLend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.ViewModels
{
    public class ToBorrowItemViewModel
    {
        public IQueryable<BorrowedItems> BorrowedItems { get; set; }

        public IQueryable<Item> Items { get; set; }

        public IQueryable<Borrower> Borrowers { get; set; }
    }
}
