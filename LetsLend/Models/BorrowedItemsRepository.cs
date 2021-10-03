using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.Models
{
    public class BorrowedItemsRepository : IBorrowedItemsRepository
    {
        private readonly AppDbContext _context;

        public BorrowedItemsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Item> AvailableItems { get => _context.Items.Where(item => item.IsAvaiable == true); }


        public IQueryable<BorrowedItems> BorrowedItems { get => _context.BorrowedItems;    }

        public void AddBorrowedItem(BorrowedItems borrowedItem)
        {
            _context.BorrowedItems.Add(borrowedItem);
            _context.SaveChanges();
            _context.BorrowedItems.OrderBy(s => s.Id).Last().CatchDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void UpdateBorrowedItem(BorrowedItems borrowedItem, string itemName)
        {
            _context.BorrowedItems.Update(borrowedItem );
            _context.SaveChanges();
        }

        public void UpdateBorrowedItem(BorrowedItems BorrowedItem)
        {
            throw new NotImplementedException();
        }
    }
}
