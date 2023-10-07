using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAuth.API.Models
{
    public class User : IdentityUser
    {

        public string? ShippingAddress { get; set; }

        public string? BillingAddress { get; set; }

        // Navigation properties
        //public ICollection<Order> Orders { get; set; }

        //public ICollection<Review> Reviews { get; set; }

        //public Wishlist Wishlist { get; set; }
    }
}
