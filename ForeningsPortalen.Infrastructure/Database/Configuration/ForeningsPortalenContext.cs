using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ForeningsPortalen.Infrastructure.Database.Configuration
{
    public class ForeningsPortalenContext : DbContext
    {
        public ForeningsPortalenContext(DbContextOptions<ForeningsPortalenContext> options) : base(options)
        {
        }
        public DbSet<Union> Unions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleHistory> UserRolesHistory { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingUnit> BookingUnit { get; set; }
        public DbSet<Category> Category { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
