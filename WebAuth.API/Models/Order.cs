using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int UserID { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; }

        public string BillingAddress { get; set; }

        public string OrderStatus { get; set; }

        // Navigation properties
        public User User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
