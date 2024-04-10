using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Managment.Core.DTO
{
    public enum Position
    {
        Secretary,
        Manager,
        Teacher,
        Supervisor,
        Assistant
    }
    public class RoleDTO
    {
        public Position Name { get; set; }
    }
}
