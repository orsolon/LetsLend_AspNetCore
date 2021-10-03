using LetsLend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LetsLend.ViewModels
{
    public class ItemViewModel
    {
        [DisplayName("Digite o nome do item para buscá-lo")]
        public string Search { get; set; }

        public IEnumerable<Item> Items { get; set; }
            }
}
