using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class BookingUnitConfiguration : IEntityTypeConfiguration<BookingUnit>
    {
        public void Configure(EntityTypeBuilder<BookingUnit> builder)
        {
            builder.HasKey(x => x.BookingUnitId);

            builder.Property(x => x.RowVersion)
                   .IsRowVersion()
                   .IsRequired();

            builder.HasMany(bu => bu.Bookings)
                .WithMany(b => b.BookingUnits)
                .UsingEntity<Dictionary<string, object>>(
                "BookingBookingUnit",
                    j => j
                        .HasOne<Booking>()
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<BookingUnit>()
                        .WithMany()
                        .HasForeignKey("BookingUnitId")
                        .OnDelete(DeleteBehavior.NoAction)
                );
        }
    }



}
