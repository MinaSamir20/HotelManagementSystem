using HotelManagementSystem.Domain.Entities;
using HotelManagementSystem.Infrastructure.Repositories.BaseRepository;

namespace HotelManagementSystem.Infrastructure.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepo<Department> Departments { get; }
        IBaseRepo<Discount> Discounts { get; }
        IBaseRepo<Guest> Guests { get; }
        IBaseRepo<Hotel> Hotels { get; }
        IBaseRepo<Payment> Payments { get; }
        IBaseRepo<Reservation> Reservations { get; }
        IBaseRepo<Room> Rooms { get; }
        IBaseRepo<RoomType> Types { get; }
        IBaseRepo<Service> Services { get; }
        IBaseRepo<Staff> Staffs { get; }
        int Complete();
    }
}
