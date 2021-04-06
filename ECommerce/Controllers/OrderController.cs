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
    public class OrderController : Controller
    {
        private MyContext _context;
        public OrderController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("orders")]
        public IActionResult OrderShowcase()
        {
            OrdersView orderView = new OrdersView()
            {
                orderlist = _context.orders.OrderByDescending(e=>e.created_at).ToList(),
                customerlist = _context.customers.OrderByDescending(e=>e.created_at).ToList(),
                productlist = _context.products.OrderByDescending(e=>e.created_at).ToList()
            };
            return View(orderView);
        }
        [HttpPost("addorder")]
        public IActionResult AddOrder(OrdersView pr)
        {
            if(ModelState.IsValid)
            {
                Order p = new Order()
                {
                    product_id = pr.order.product_id,
                    item_count = pr.order.item_count,
                    customer_id = pr.order.customer_id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                _context.orders.Add(p);
                _context.SaveChanges();
                return RedirectToAction("OrderShowcase");
            }
            return RedirectToAction("OrderShowcase");
        }

    }
}