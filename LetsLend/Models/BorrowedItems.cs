using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LetsLend.Models
{
    public class BorrowedItems
    {
        public BorrowedItems()
        {
            this.Itens = new List<Item>();
        }
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int BorrowerId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CatchDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
        public ICollection<Item> Itens { get; set; }
    }
}
