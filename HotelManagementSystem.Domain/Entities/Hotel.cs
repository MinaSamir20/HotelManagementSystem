using HotelManagementSystem.Domain.Bases;
using HotelManagementSystem.Domain.ValueObject;

namespace HotelManagementSystem.Domain.Entities
{
    public class Hotel : BaseEntity
    {
        public string? HotelName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Website { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public int FloorCount { get; set; }
        public int TotalRooms { get; set; }
        public Address? Address { get; set; }

        public IEnumerable<Department>? Departments { get; set; }
        public IEnumerable<GuestHotel>? Guests { get; set; }
        public IEnumerable<Reservation>? Reservations { get; set; }
        public IEnumerable<Room>? Rooms { get; set; }
        public IEnumerable<RoomType>? Types { get; set; }
        public IEnumerable<Service>? Services { get; set; }
        public IEnumerable<Staff>? Staffs { get; set; }
    }
}
