using ForeningsPortalen.Website.Models.Address;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<DeleteAddressModel> Address { get; set; }
        public DbSet<Member> Member { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("TESTtilscafolding");
        }
        public DbSet<ForeningsPortalen.Website.Models.BookingUnit> BookingUnit { get; set; } = default!;
        public DbSet<ForeningsPortalen.Website.Models.Document> Document { get; set; } = default!;
        public DbSet<ForeningsPortalen.Website.Models.Booking.BookingIndexModel> BookingIndexModel { get; set; } = default!;
    }
}
