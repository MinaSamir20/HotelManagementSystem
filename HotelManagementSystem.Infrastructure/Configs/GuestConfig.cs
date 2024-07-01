using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class GuestConfig : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Guests");

            builder.OwnsOne(x => x.Address);

            builder.HasOne(g => g.User)
                .WithMany(u => u.Guest)
                .HasForeignKey(g => g.UserId);

            builder.HasOne(g => g.Reservation)
                .WithOne(u => u.Guest)
                .HasForeignKey<Reservation>(r => r.GuestId);
        }
    }
}
