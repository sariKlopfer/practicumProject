using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Managment.API.Model;
using Managment.Core.DTO;
using Managment.Core.Entities;
using Managment.Core.Services;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        
        public IActionResult Get()
        {
            //את התפקידים צריך לעבור על מערך התפקידים ולהוציא משם
            var employees = _employeeService.GetEmployees();
            var employeeDtos = _mapper.Map<IEnumerable<EmployeeDTO>>(employees);
            return Ok(employeeDtos);
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] EmployeePostModel employee)
        {
            var emp = new Employee()
            {
                IdNumber = employee.IdNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DateOfBirth = employee.DateOfBirth,
                DateOfStart = employee.DateOfStart,
                Gender = (Managment.Core.Entities.Gender)employee.Gender,
                Address = employee.Address,
                Status = (Managment.Core.Entities.Status)1,
                Roles = employee.Roles
                //לשלוח מכאן לקונטרולר של הוספה תפקיד עם ID 

            };
            return Ok(_employeeService.AddEmployee(emp));
        }
        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            var Employee = new Employee()
            {
                Address = employee.Address,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DateOfBirth = employee.DateOfBirth,
                DateOfStart = employee.DateOfStart,
                Gender = employee.Gender,
                Status = (Managment.Core.Entities.Status)1,
                Roles = employee.Roles
            };
            return Ok(_employeeService.UpdateEmployee(id, Employee));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_employeeService.DeleteEmployee(id));
        }

    }
}
