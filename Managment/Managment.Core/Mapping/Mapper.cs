//using AutoMapper; // יבוא של הספרייה AutoMapper שמאפשרת ביצוע מיפוי בין סוגי נתונים שונים ב-.NET
//using Managment.Core.DTO; // יבוא של משתנים מהספרייה Managment.Core.DTO
//using Managment.Core.Entities; // יבוא של משתנים מהספרייה Managment.Core.Entities
//using System; // יבוא של הספרייה System
//using System.Collections.Generic; // יבוא של הספרייה System.Collections.Generic
//using System.Linq; // יבוא של הספרייה System.Linq
//using System.Text; // יבוא של הספרייה System.Text
//using System.Threading.Tasks; // יבוא של הספרייה System.Threading.Tasks

//namespace Managment.Core.Mapping // הגדרת המרחב השמות Managment.Core.Mapping
//{
//    public class Mapper : Profile // הגדרת מחלקה בשם Mapper היורשת מהמחלקה Profile של AutoMapper
//    {
//        public Mapper() // בנאי המחלקה
//        {
//            // הגדרת מיפוי בין סוג הנתונים Employee לבין סוג הנתונים EmployeeDTO וההפוך
//            CreateMap<Employee, EmployeeDTO>().ReverseMap();

//            // הגדרת מיפוי בין סוג הנתונים EmployeeRole לבין סוג הנתונים EmployeeRoleDTO
//            CreateMap<EmployeeRole, EmployeeRoleDTO>();

//            // הגדרת מיפוי בין סוג הנתונים Role לבין סוג הנתונים RoleDTO וההפוך
//            CreateMap<Role, RoleDTO>().ReverseMap();
//        }
//    }
//}
