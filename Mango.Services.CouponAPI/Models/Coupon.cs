using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        public string CouponCode { get; set; }

        [Required]
        public double DiscountAmout { get; set; }

        public int MinAmount { get; set; }
    }
}
