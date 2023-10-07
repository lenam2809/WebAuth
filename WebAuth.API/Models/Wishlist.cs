using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Wishlist
    {
        [Key]
        public int WishlistID { get; set; }

        public int UserID { get; set; }

        // Navigation properties
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
