using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
