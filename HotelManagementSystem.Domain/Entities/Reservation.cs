using HotelManagementSystem.Domain.Bases;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Domain.Entities
{
    public class Reservation : BaseEntity
    {
        public DateTime BookingDate { get; set; }
        public int StayDuration { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public float BookingAmount { get; set; }

        [AllowedValues(["Checkin", "Checkout"])]
        public string? Status { get; set; } = "Checkin";

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }

        public int GuestId { get; set; }
        public Guest? Guest { get; set; }

        public int DiscountId { get; set; }
        public Discount? Discount { get; set; }

        public IEnumerable<RoomBooked>? Rooms { get; set; }
        public IEnumerable<Payment>? Payments { get; set; }
        public IEnumerable<ServiceReservation>? Services { get; set; }
    }
}
