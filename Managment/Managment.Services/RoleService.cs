using Managment.Core.Entities; // יבוא של מחלקת הישויות
using Managment.Core.Repository; // יבוא של האינטרפייס של הרפוזיטורי
using Managment.Core.Services; // יבוא של האינטרפייס של השירות
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public List<Role> GetRoles()
        {
            return _roleRepository.GetRoles();
        }

        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public Role AddRole(Role role)
        {
            return _roleRepository.AddRole(role);
        }
        public Role UpdateRole(int id, Role role) 
        { 
            return (_roleRepository.UpdateRole(id, role));
        }

        public Role DeleteRole(int id)
        { 
            return _roleRepository.DeleteRole(id);
        }

    }
}
