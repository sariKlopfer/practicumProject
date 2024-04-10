using Managment.Core.Entities;

namespace Managment.API.Model
{
    public enum Gender
    {
        Male, Female
    }
    public enum Status
    {
        Active, Inactive
    }
    public class EmployeePostModel 
    {
        public string IdNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Status Status { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfStart { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Role> Roles { get; set; }
    }
}

