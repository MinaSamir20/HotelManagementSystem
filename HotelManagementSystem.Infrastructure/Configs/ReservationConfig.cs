using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Reservation");

            builder.HasOne(r => r.Guest)
                .WithOne(h => h.Reservation)
                .HasForeignKey<Reservation>(r => r.GuestId);

            builder.HasOne(r => r.Hotel)
                .WithMany(h => h.Reservations)
                .HasForeignKey(r => r.HotelId);

            builder.HasOne(r => r.Staff)
                .WithMany(h => h.Reservations)
                .HasForeignKey(r => r.HotelId);

            builder.HasOne(r => r.Discount)
                .WithMany(h => h.Reservations)
                .HasForeignKey(r => r.DiscountId);
        }
    }
}
