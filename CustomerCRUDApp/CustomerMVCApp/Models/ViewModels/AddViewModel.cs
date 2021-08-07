using Customers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerMVCApp.Models.ViewModels
{
    public class AddViewModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public String Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Enter Location")]
        public String Location
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Enter Blance")]
        [Range(1000, double.MaxValue, ErrorMessage = "Please Enter Balance Above 1000")]
        public double Balance
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Enter Type")]
        public String Type
        {
            get;
            set;
        }
    }
}