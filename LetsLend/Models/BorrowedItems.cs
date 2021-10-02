using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsLend.Models
{
    public class BorrowedItems
    {
        //public BorrowedItems()
        //{
        //    this.Items = new List<Item>();
        //}

        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int BorrowerId { get; set; }

        [ForeignKey("BorrowerId")]
        public Borrower Borrower { get; set; }

        [DataType(DataType.Date)]
        public DateTime CatchDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}