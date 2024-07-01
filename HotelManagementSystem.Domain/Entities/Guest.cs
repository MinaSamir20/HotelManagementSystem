using HotelManagementSystem.Domain.Bases;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Domain.Entities
{
    public class Guest : UserEntity
    {
        public string? PassportNumber { get; set; }

        [AllowedValues(["Reserved", "Not Reserved"])]
        public string? Status { get; set; } = "Not Reserved";

        public Reservation? Reservation { get; set; }

        public IEnumerable<GuestHotel>? Hotels { get; set; }
    }
}
