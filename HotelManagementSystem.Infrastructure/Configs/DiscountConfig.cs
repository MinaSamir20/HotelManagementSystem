using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class DiscountConfig : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Discounts");

            builder.HasOne(d => d.Staff)
                .WithMany(s => s.Discounts)
                .HasForeignKey(d => d.StaffId);
        }
    }
}
