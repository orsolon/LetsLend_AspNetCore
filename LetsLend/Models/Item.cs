using System.ComponentModel.DataAnnotations;

namespace LetsLend.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome é obrigatorio")]
        public string Nome { get; set; }
        public string Description { get; set; }
        public bool IsAvaiable { get; set; }
    }
}
