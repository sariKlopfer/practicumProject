using Managment.Core.Entities;
namespace Managment.API.Model
{
    public enum Position
    {
        Secretary,
        Manager,
        Teacher,
        Supervisor,
        Assistant
    }
    public class RolePostModel
    {
        public Position Name { get; set; }

        public bool IsManagerial { get; set; }

        public DateTime DateOfStart { get; set; }
    }
}
