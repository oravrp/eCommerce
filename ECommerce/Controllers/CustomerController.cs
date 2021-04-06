using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Models.ViewModels;

namespace ECommerce.Controllers
{
    public class CustomerController : Controller
    {
        private MyContext _context;
        public CustomerController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("customers")]
        public IActionResult CustomerShowcase()
        {
            CustomersView customersView = new CustomersView()
            {
                customerlist = _context.customers.OrderByDescending(e=>e.created_at).ToList()
            };
            return View(customersView);
        }
        [HttpPost("addcustomer")]
        public IActionResult AddCustomer(CustomersView pr)
        {
            if(ModelState.IsValid)
            {
                Customer p = new Customer()
                {
                    name = pr.customer.name,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                _context.customers.Add(p);
                _context.SaveChanges();
                return RedirectToAction("CustomerShowcase");
            }
            return RedirectToAction("CustomerShowcase");
        }
        [HttpPost("remove")]
        public IActionResult RemoveCustomer(int id)
        {
            _context.customers.Remove(_context.customers.Where(e=>e.customer_id==id).SingleOrDefault());
            _context.SaveChanges();
            return RedirectToAction("CustomerShowcase");
        }
    }
}