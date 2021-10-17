using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LetsLend.Models
{
    public class BorrowedItems
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Id do item é obrigatorio")]
        //public int ItemId { get; set; }

        //[Required(ErrorMessage = "Nome do item é obrigatorio")]
        public int ItemId { get; set; }

        //[ForeignKey("ItemId")]
        //public Item Item { get; set; }

        //[Required(ErrorMessage = "Id do cliente é obrigatorio")]
        //public int BorrowerId { get; set; }

        //[Required(ErrorMessage = "Nome do cliente é obrigatorio")]
        //[DefaultValue("")]
        public int BorrowerId { get; set; }

        //[ForeignKey("BorrowerId")]
        //public Borrower Borrower { get; set; }

        [Required(ErrorMessage = "Data de cautela é obrigatória")]
        [DataType(DataType.Date)]
        public DateTime CatchDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}