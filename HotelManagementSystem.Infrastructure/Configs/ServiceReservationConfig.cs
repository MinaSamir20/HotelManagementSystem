using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class ServiceReservationConfig : IEntityTypeConfiguration<ServiceReservation>
    {
        public void Configure(EntityTypeBuilder<ServiceReservation> builder)
        {
            builder.HasKey(x => new { x.ServiceId, x.ReservationId });
            builder.ToTable("ServiceReservations");

            builder.HasOne(sr => sr.Service)
                .WithMany(s => s.Reservations)
                .HasForeignKey(sr => sr.ServiceId);

            builder.HasOne(sr => sr.Reservation)
                .WithMany(r => r.Services)
                .HasForeignKey(sr => sr.ReservationId);
        }
    }
}
