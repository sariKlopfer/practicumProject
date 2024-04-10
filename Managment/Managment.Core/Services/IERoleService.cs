using Managment.Core.Entities; // יבוא של הספרייה Managment.Core.Entities
using System; // יבוא של הספרייה System
using System.Collections.Generic; // יבוא של הספרייה System.Collections.Generic
using System.Linq; // יבוא של הספרייה System.Linq
using System.Text; // יבוא של הספרייה System.Text
using System.Threading.Tasks; // יבוא של הספרייה System.Threading.Tasks

namespace Managment.Core.Services // הגדרת המרחב השמות Managment.Core.Services
{
    public interface IRoleService
    {
        List<Role> GetRoles();

        Role GetById(int id);
        Role AddRole(Role role);
        Role UpdateRole(int id, Role role);
        Role DeleteRole(int id);

    }
}

