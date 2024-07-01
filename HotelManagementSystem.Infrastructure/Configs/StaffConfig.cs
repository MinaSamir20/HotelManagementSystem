using HotelManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagementSystem.Infrastructure.Configs
{
    public class StaffConfig : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Staffs");

            builder.OwnsOne(x => x.Address);

            builder.HasOne(s => s.User)
                .WithMany(u => u.Staff)
                .HasForeignKey(s => s.UserId);

            builder.HasOne(s => s.Department)
                .WithMany(d => d.Staffs)
                .HasForeignKey(s => s.DepartmentId);

            builder.HasOne(s => s.Hotel)
                .WithMany(h => h.Staffs)
                .HasForeignKey(s => s.HotelId);
        }
    }
}
