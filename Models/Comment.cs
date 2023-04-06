using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        [Required]
        [MaxLength(100),MinLength(1)]
        public string? CommentText { get; set;}

        //!navigation properties//
        [Required]
        public int AnimalId { get; set; }
        public virtual Animal? Animal { get; set; }
    }
}
