using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Shipping
    {
        [Key]
        public int ShippingID { get; set; }

        public int OrderID { get; set; }

        [Required]
        public string ShippingCarrier { get; set; }

        public string TrackingNumber { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public string ShippingStatus { get; set; }

        // Navigation properties
        public Order Order { get; set; }
    }
}
