using Managment.Core.Entities; 
using System; 
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace Managment.Core.Repository 
{
    public interface IRoleRepository
    {
        List<Role> GetRoles();

        Role GetById(int id);

        Role AddRole(Role role);

        Role UpdateRole(int id, Role role);

        Role DeleteRole(int id);
    }
}
