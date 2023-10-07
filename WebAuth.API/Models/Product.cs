using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal ProductRating { get; set; }

        // Navigation properties
        public Category Category { get; set; }

        //public ICollection<Review> Reviews { get; set; }
    }
}
