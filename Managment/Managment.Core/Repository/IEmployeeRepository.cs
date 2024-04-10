using Managment.Core.Entities; 
using System; 
using System.Collections.Generic; 
using System.Text; 
using System.Threading.Tasks; 

namespace Managment.Core.Repository 
{
    public interface IEmployeeRepository 
    {
        List<Employee> GetEmployees();

        Employee GetById(int id);

        Employee AddEmployee(Employee employee);
        Employee DeleteEmployee(int id);

        Employee UpdateEmployee(int id, Employee user);


    }
}
