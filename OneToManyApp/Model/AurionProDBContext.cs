using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp.Model
{
    public class AurionProDBContext: DbContext
    {
        public DbSet<Department> Departments
        {
            get;
            set;
        }

        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}
