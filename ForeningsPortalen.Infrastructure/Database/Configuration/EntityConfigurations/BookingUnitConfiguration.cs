using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Domain.Entities;

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
