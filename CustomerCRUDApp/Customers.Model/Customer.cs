using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Model
{
    public class Customer
    {
        public int Id
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Location
        {
            get;
            set;
        }

        public Double Balance
        {
            get;
            set;
        }

        public String Type
        {
            get;
            set;
        }
    }
}
