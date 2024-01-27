using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(
                new Coupon
                {
                    Id = 1,
                    CouponCode = "10OFF",
                    DiscountAmout = 10,
                    MinAmount = 20
                },
                new Coupon
                {
                    Id = 2,
                    CouponCode = "20OFF",
                    DiscountAmout = 20,
                    MinAmount = 40
                }
            );
        }
    }
}
