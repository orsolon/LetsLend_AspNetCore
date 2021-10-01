using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.Models
{
    public interface IRepositoryItem
    {
        IQueryable<Item> Items { get; }
        void AddItem(Item item);
        void UpdateItem(Item item);
        void RemoveItem(Item item);
    }
}
