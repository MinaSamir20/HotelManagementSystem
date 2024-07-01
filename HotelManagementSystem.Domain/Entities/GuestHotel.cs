namespace HotelManagementSystem.Domain.Entities
{
    public class GuestHotel
    {
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public int GuestId { get; set; }
        public Guest? Guest { get; set; }
    }
}
