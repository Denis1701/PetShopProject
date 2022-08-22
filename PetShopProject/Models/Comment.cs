using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal? Animal { get; set; }
        [Required]
        public string? CommentText { get; set; }
    }
}
