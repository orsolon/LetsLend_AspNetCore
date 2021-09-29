using LetsLend.Models;
using System.Collections.Generic;
using System.Linq;

namespace LetsLend.Models
{
    public class ItemRepository
    {
        private static List<Item> items = new List<Item>();

        public static IEnumerable<Item> Items { get => items; }

        public static void AddItem(Item item)
        {
            items.Add(item);
        }
    }
}