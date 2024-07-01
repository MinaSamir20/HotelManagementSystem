using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Staff : UserEntity
    {
        public string? Designation { get; set; }
        public DateOnly JoiningDate { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }

        public IEnumerable<Discount>? Discounts { get; set; }
        public IEnumerable<Reservation>? Reservations { get; set; }
    }
}
