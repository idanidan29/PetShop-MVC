using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string? Name { get; set; }

        //!navigation properties//
        public virtual ICollection<Animal>? animals { get; set; }
    }
}
