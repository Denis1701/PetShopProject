using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PetShopProject.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Required]
        [StringLength(20)]
        public string? Name { get; set; }
        [Required]
        [DataType("double")]
        
        public double Age { get; set; }
        [Required]
        public string? PictureSource { get; set; }
        [Required]
        public string? Description { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        [DataType("double")]
        public double Price { get; set; }
    }
}
