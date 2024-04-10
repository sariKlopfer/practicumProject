using Managment.Core.Entities; // יבוא של הספרייה Managment.Core.Entities
using Managment.Core.Repository; // יבוא של הממשק Managment.Core.Repository
using System; // יבוא של הספרייה System
using System.Collections.Generic; // יבוא של הספרייה System.Collections.Generic
using System.Linq; // יבוא של הספרייה System.Linq
using System.Text; // יבוא של הספרייה System.Text
using System.Threading.Tasks; // יבוא של הספרייה System.Threading.Tasks

namespace Managment.Core.Services // הגדרת המרחב השמות Managment.Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetById(int id);

        Employee AddEmployee(Employee employee);

        Employee UpdateEmployee(int id, Employee employee);

        Employee DeleteEmployee(int id);


    }
}
