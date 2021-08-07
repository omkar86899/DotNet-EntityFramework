using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Model
{
    public class AurionProDBCotext: DbContext
    {
        public AurionProDBCotext(): base("name=AurionproDBContext")
        {

        }

        public DbSet<Customer> Customers
        {
            get;
            set;
        }
    }
}
