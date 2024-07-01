using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public string? PaymentStatus { get; set; }
        public string? PaymentType { get; set; }
        public float? PaymentAmount { get; set; }

        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
