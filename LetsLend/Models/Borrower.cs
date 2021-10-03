using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.Models
{
    public class Borrower
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatorio")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatorio")]
        public string Email { get; set; }
    }
}
