using ForeningsPortalen.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace ForeningsPortalen.Infrastructure.Database.Configuration.EntityConfigurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(x => x.BookingId);

            builder.Property(x => x.RowVersion)
                   .IsRowVersion()
                   .IsRequired();

            builder.HasMany(b => b.BookingUnits)
                .WithMany(bu => bu.Bookings)
                .UsingEntity<Dictionary<string, object>>(
                    "BookingBookingUnit",
                    j => j
                        .HasOne<BookingUnit>()
                        .WithMany()
                        .HasForeignKey("BookingUnitId")
                        .OnDelete(DeleteBehavior.NoAction),
                    j => j
                        .HasOne<Booking>()
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.NoAction)
                );
        }
    }


}