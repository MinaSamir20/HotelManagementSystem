using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("RoomTypes");

            builder.HasOne(rt => rt.Hotel)
                .WithMany(h => h.Types)
                .HasForeignKey(rt => rt.HotelId);
        }
    }
}
