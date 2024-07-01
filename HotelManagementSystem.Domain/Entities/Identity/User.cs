using Microsoft.AspNetCore.Identity;

namespace HotelManagementSystem.Domain.Entities.Identity
{
    public class User : IdentityUser
    {
        public User()
        {
            Guest = new HashSet<Guest>();
            Staff = new HashSet<Staff>();
        }
        public string? ImageUrl { get; set; }
        public List<RefreshToken>? RefreshTokens { get; set; }

        public ICollection<Guest> Guest { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
