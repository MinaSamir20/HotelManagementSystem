using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float? ServiceCost { get; set; }

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public IEnumerable<ServiceReservation>? Reservations { get; set; }
    }
}
