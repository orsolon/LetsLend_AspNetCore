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

        //public string GetAtrasados(BorrowedItems BorrowedItem, Item Items)
        //{

        //    var atraso = BorrowedItem.Id.Equals(Items.Id) && BorrowedItem.ReturnDate < System.DateTime.Now;

        //    return atraso

        //}
    }
}

