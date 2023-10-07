using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }

        public int Rating { get; set; }

        public string ReviewText { get; set; }

        public DateTime ReviewDate { get; set; }

        // Navigation properties
        public User User { get; set; }

        public Product Product { get; set; }
    }
}
