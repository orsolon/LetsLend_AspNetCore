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

            /* validações */
            /*if (item.IsAvaiable = false)
                item.ItemBorrower = "Livre";*/

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

            //items.Remove(item);
        }


    }
}