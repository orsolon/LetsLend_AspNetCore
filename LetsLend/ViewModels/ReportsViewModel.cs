using LetsLend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.ViewModels
{
    public class ReportsViewModel
    {
        public IEnumerable<Item> Items { get; set; }

        public IEnumerable<Borrower> Borrowers { get; set; }

        public IEnumerable<BorrowedItems> BorroweedItems { get; set; }
    }
}
