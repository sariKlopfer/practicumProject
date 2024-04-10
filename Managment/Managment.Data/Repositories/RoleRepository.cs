using Managment.Core.Entities;
using Managment.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public Role AddRole(Role role)
        {
            _context.RoleNamesArr.Add(role);
            _context.SaveChanges();
            return role;
        }

       
        public Role GetById(int id)
        {
            return _context.RoleNamesArr.ToList().Find(u => u.Id == id);
        }

        public List<Role> GetRoles()
        {
            return _context.RoleNamesArr.ToList();
        }

        public Role UpdateRole(int id, Role role)
        {
            var updateRole = _context.RoleNamesArr.ToList().Find(u => u.Id == id);
            if (updateRole != null)
            {
                updateRole.IsManagerial = role.IsManagerial;
                updateRole.DateOfStart = role.DateOfStart;
                updateRole.Name = role.Name;
                return updateRole;
            }
            return null;
        }
        public Role DeleteRole(int id)
        {
            var role = _context.RoleNamesArr.ToList().Find(u => u.Id == id);
            _context.RoleNamesArr.Remove(role);
            _context.SaveChanges();
            return role;
        }


    }
}
