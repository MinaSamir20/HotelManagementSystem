using HotelManagementSystem.Domain.Commands;
using HotelManagementSystem.Domain.Entities.Identity;
using HotelManagementSystem.Domain.ValueObject;

namespace HotelManagementSystem.Domain.Bases
{
    public class UserEntity : LocalizableEntity
    {
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public string? NationalID { get; set; }
        public string? Gender { get; set; }
        public DateTime DOB { get; set; }
        public Address? Address { get; set; }

        /*-------- Relations --------*/

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
