using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class GestsHotelsConfig : IEntityTypeConfiguration<GuestHotel>
    {
        public void Configure(EntityTypeBuilder<GuestHotel> builder)
        {
            builder.ToTable("GuestsHotels");
            builder.HasKey(gh => new { gh.HotelId, gh.GuestId });

            builder.HasOne(gh => gh.Hotel)
                .WithMany(h => h.Guests)
                .HasForeignKey(gh => gh.HotelId);

            builder.HasOne(gh => gh.Guest)
                .WithMany(h => h.Hotels)
                .HasForeignKey(gh => gh.GuestId);
        }
    }
}
