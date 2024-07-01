using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Discount : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float DiscountRate { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }

        public IEnumerable<Reservation>? Reservations { get; set; }
    }
}
