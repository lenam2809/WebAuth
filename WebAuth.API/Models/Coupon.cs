using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }

        [Required]
        //[Index(IsUnique = true)]
        public string Code { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal DiscountPercentage { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string ApplicableProducts { get; set; } // Có thể lưu các sản phẩm hoặc danh mục áp dụng dưới dạng JSON hoặc dạng văn bản khác

        // Other coupon-related properties

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
    }
}
