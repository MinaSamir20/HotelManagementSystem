using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class RoomBookedConfig : IEntityTypeConfiguration<RoomBooked>
    {
        public void Configure(EntityTypeBuilder<RoomBooked> builder)
        {
            builder.HasKey(x => new { x.ReservationId, x.RoomId });
            builder.ToTable("RoomBookeds");

            builder.HasOne(rb => rb.Reservation)
                .WithMany(r => r.Rooms)
                .HasForeignKey(rb => rb.ReservationId);

            builder.HasOne(rb => rb.Room)
                .WithMany(r => r.Bookeds)
                .HasForeignKey(rb => rb.RoomId);
        }
    }
}
