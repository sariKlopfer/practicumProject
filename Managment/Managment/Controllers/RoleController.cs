using AutoMapper;
using Managment.Core.Entities;
using Managment.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Managment.API.Model;
using Managment.Core.DTO;
using Managment.Core.Entities;
using Managment.Core.Services;
using Managment.Services;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public RolesController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleService.GetRoles().ToList());

            var roles = _roleService.GetRoles();
            var roleDtos = _mapper.Map<IEnumerable<EmployeeDTO>>(roles);
            return Ok(roleDtos);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var role = _roleService.GetById(id);
            if (role is null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] RolePostModel role)
        {
            var r = new Role()
            {
                // Name = role.Name,
                IsManagerial = role.IsManagerial,
                DateOfStart = role.DateOfStart,

            };
            return Ok(_roleService.AddRole(r));
        }
        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Role value)
        {
            return Ok(_roleService.UpdateRole(id, value));
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_roleService.DeleteRole(id));
        }
    }
}
