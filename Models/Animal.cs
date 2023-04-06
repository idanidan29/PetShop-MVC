using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Animal
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter a valid name")]
        [StringLength(14, MinimumLength = 2)]
        public string? Name { get; set; }
        [Range(1, 500)]
        [Required(ErrorMessage = "please enter a valid age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "please enter a valid Description")]
        [StringLength(400, MinimumLength = 3)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "please enter a valid file")]
        public string? Picture { get; set; }

        //!navigation properties//
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Comment>? comments { get; set; }

    }
}
