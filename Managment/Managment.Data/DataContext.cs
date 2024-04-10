using Managment.Core.Entities; // יבוא של מחלקת הישויות
using Microsoft.EntityFrameworkCore; // יבוא של ספריית Entity Framework Core
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
//using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Data
{
    public class DataContext : DbContext // מחלקה שיורשת מ DbContext המייצגת קשר עם בסיס הנתונים
    {
        public DbSet<Employee> Employees { get; set; } // קבוצת העובדים בבסיס הנתונים
        public DbSet<Role> RoleNamesArr { get; set; } // קבוצת תפקידי העובדים בבסיס הנתונים

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // הגדרת אפשרויות התקשרות לבסיס הנתונים
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=dataDB"); // הגדרת מסד הנתונים והשרת
            optionsBuilder.LogTo((message) => Debug.Write(message)); // הגדרת פונקציה שתכתוב את הפעולות ללוג לפי דרישת המפתח
        }
        //2024-04-09T07:08:10.407Z
    }
}
