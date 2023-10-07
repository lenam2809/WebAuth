using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public int? ParentCategoryID { get; set; }

        // Navigation properties
        public Category ParentCategory { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
