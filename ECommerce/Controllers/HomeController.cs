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
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Dashboard()
        {
            DashboardView dashboardView = new DashboardView()
            {
                customerlist = _context.customers.OrderByDescending(e=>e.created_at).Take(5).ToList()
                ,orderlist = _context.orders.OrderByDescending(e=>e.created_at).Take(5).ToList()
                ,productlist = _context.products.OrderByDescending(e=>e.created_at).Take(5).ToList()
            };
            return View(dashboardView);
        }

    }
}