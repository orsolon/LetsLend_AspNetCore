using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.Models
{
    public interface IBorrowedItemsRepository
    {
        IQueryable<BorrowedItems> BorrowedItems { get; }
        IQueryable<Item> AvailableItems { get; }
        void AddBorrowedItem(BorrowedItems borrowedItem);
        void UpdateBorrowedItem(BorrowedItems BorrowedItem);
        void UpdateBorrowedItem(BorrowedItems BorrowedItem, string itemName);
    }
}