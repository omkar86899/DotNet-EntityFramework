using CustomerMVCApp.Models.ViewModels;
using Customers.Model;
using Customers.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService _customerService;
        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            DisplayViewModel vm = new DisplayViewModel();
            vm.Customers = _customerService.GetCustomers();
            vm.Count = _customerService.GetCustomers().Count;
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            AddViewModel vm = new AddViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Add(AddViewModel vm)
        {
            Customer customer;
            if (!this.ModelState.IsValid)
            {
                return View(vm);
            }
            customer = new Customer {Name=vm.Name, Location=vm.Location, Balance=vm.Balance, Type=vm.Type };
            _customerService.Add(customer);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EditViewModel vm;
            Customer customer;
            customer = _customerService.GetCustomer(id);
            vm = new EditViewModel();
            vm.Id = id;
            vm.Name = customer.Name;
            vm.Location = customer.Location;
            vm.Balance = customer.Balance;
            vm.Type = customer.Type;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(EditViewModel vm)
        {
            Customer customer;
            if (!this.ModelState.IsValid)
            {
                return View(vm);
            }
            customer = new Customer { Id = vm.Id, Name = vm.Name, Balance = vm.Balance, Location = vm.Location, Type = vm.Type };
            _customerService.EditCustomer(customer);
            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _customerService.DeleteCustomer(id);
            return RedirectToAction("index");
        }
    }
}