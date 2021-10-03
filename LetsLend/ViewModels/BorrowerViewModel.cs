using LetsLend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.ViewModels
{
    public class BorrowerViewModel
    {
        [DisplayName("Digite o nome do locador para buscá-lo")]
        public string Search { get; set; }

        public IEnumerable<Borrower> Borrowers { get; set; }
    }
}

