using LetsLend.Models;
using System.Collections.Generic;
using System.Linq;

namespace LetsLend.Models
{
    public class ItemRepository : IRepositoryItem
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public IQueryable<Item> Items { get => _context.Items; }

        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public void ChangeItemBorrower(int itemId, string borrowerName)
        {
            _context.Items.FirstOrDefault(x => x.Id == itemId).ItemBorrower = borrowerName;
            _context.SaveChanges();
        }


        public void UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
        }

        public void RemoveItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
        }

        public void ChangeAvailability(Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}