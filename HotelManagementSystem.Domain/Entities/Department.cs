using HotelManagementSystem.Domain.Bases;

namespace HotelManagementSystem.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string? DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
        public int InitialSalary { get; set; }
        public string? Designation { get; set; }

        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public IEnumerable<Staff>? Staffs { get; set; }
    }
}
