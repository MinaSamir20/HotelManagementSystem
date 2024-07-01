namespace HotelManagementSystem.Domain.Entities
{
    public class ServiceReservation
    {
        public int ServiceId { get; set; }
        public Service? Service { get; set; }

        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
