using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class RoomType : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Cost { get; set; }
        public bool SmokeFriendly { get; set; }
        public bool PetFriendly { get; set; }

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public IEnumerable<Room>? Rooms { get; set; }
    }
}
