using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        public int UserID { get; set; }

        public int OrderID { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal PaymentAmount { get; set; }

        public DateTime PaymentDate { get; set; }

        // Navigation properties
        public User User { get; set; }

        public Order Order { get; set; }
    }
}
