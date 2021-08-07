using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp.Model
{
    public class Employee
    {
        [Key]
        public int EmpNo
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }

        public virtual Department Dept
        {
            get;
            set;
        }
    }
}
