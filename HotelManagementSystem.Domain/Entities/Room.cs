using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Room : BaseEntity
    {
        public string? RoomNumber { get; set; }
        public bool Avilable { get; set; } = true;

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }

        public IEnumerable<RoomBooked>? Bookeds { get; set; }
    }
}
