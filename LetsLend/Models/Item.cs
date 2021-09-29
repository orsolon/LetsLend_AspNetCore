using System.ComponentModel.DataAnnotations;

namespace LetsLend.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome é obrigatorio")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public bool IsAvaiable { get; set; }
        public string ItemBorrower { get; set; }
    }
}
