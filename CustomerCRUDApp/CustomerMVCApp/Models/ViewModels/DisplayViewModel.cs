using Customers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVCApp.Models.ViewModels
{
    public class DisplayViewModel
    {
        public List<Customer> Customers
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }
    }
}