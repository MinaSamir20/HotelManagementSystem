using Microsoft.EntityFrameworkCore;

namespace HotelManagementSystem.Domain.ValueObject
{
    [Owned]
    public class Address
    {
        public string Country { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string AddressLine { get; set; } = string.Empty;

        public Address() { }
    }
}
