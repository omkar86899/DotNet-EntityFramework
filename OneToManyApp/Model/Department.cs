using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp.Model
{
    public class Department
    {
        [Key]
        public int DeptNo
        {
            set;
            get;
        }

        public String DeptName
        {
            get;
            set;
        }

        public String Location
        {
            get;
            set;
        }

        public virtual List<Employee> Employees
        {
            get;
            set;
        }
    }
}
