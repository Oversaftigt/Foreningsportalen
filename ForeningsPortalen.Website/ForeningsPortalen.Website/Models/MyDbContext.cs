using ForeningsPortalen.Website.Models.Address;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using ForeningsPortalen.Website.Models.Category;

namespace ForeningsPortalen.Website.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<DeleteAddressModel> Address { get; set; }
        /*public DbSet<Member> Member { get; set; }*/


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("TESTtilscafolding");
        }
        public DbSet<BookingUnit.IndexBookingUnitModel> BookingUnit { get; set; } = default!;
        public DbSet<ForeningsPortalen.Website.Models.Document> Document { get; set; } = default!;
        public DbSet<ForeningsPortalen.Website.Models.Booking.BookingIndexModel> BookingIndexModel { get; set; } = default!;
        public DbSet<ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union.UnionQueryResultDto> UnionQueryResultDto { get; set; } = default!;
        public DbSet<IndexCategoryModel> IndexCategoryModel { get; set; } = default!;
    }
}
