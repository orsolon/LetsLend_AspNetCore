using System;
using System.Collections.Generic;

namespace LetsLend.Models
{
    public class BorrowedItems
    {
        public BorrowedItems()
        {
            this.Itens = new List<Item>();
        }
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime CatchDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public ICollection<Item> Itens { get; set; }
    }
}
