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


        public IQueryable<BorrowedItems> BorrowedItems { get => _context.BorrowedItems;    }








    public void AddBorrow(BorrowedItems BorrowedItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateBorrow(BorrowedItems BorrowedItem)
        {
            throw new NotImplementedException();
        }
    }
}
