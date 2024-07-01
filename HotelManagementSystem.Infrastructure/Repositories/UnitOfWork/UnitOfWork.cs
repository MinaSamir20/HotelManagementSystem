using HotelManagementSystem.Domain.Entities;
using HotelManagementSystem.Infrastructure.Database;
using HotelManagementSystem.Infrastructure.Repositories.BaseRepository;

namespace HotelManagementSystem.Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Departments = new BaseRepo<Department>(_db);
            Discounts = new BaseRepo<Discount>(_db);
            Guests = new BaseRepo<Guest>(_db);
            Hotels = new BaseRepo<Hotel>(_db);
            Payments = new BaseRepo<Payment>(_db);
            Reservations = new BaseRepo<Reservation>(_db);
            Rooms = new BaseRepo<Room>(_db);
            Types = new BaseRepo<RoomType>(_db);
            Services = new BaseRepo<Service>(_db);
            Staffs = new BaseRepo<Staff>(_db);
        }

        public IBaseRepo<Room> Rooms { get; private set; }

        public IBaseRepo<Department> Departments { get; private set; }

        public IBaseRepo<Discount> Discounts { get; private set; }

        public IBaseRepo<Guest> Guests { get; private set; }

        public IBaseRepo<Hotel> Hotels { get; private set; }

        public IBaseRepo<Payment> Payments { get; private set; }

        public IBaseRepo<Reservation> Reservations { get; private set; }

        public IBaseRepo<RoomType> Types { get; private set; }

        public IBaseRepo<Service> Services { get; private set; }

        public IBaseRepo<Staff> Staffs { get; private set; }

        public int Complete() => _db.SaveChanges();

        public void Dispose() => _db.Dispose();
    }
}
