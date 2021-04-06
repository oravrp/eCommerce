using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private MyContext _context;
        public ProductController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("products")]
        public IActionResult ProductShowcase(string prodsearchkeyword)
        {
            ProductsView productView = new ProductsView()
            {
                
                productlist =  _context.products
                                .Where(e=>prodsearchkeyword == null || e.name.Contains(prodsearchkeyword) || e.description.Contains(prodsearchkeyword))
                                .OrderByDescending(e=>e.created_at)
                                .ToList()
            };
            return View(productView);
        }
        [HttpPost("add")]
        public IActionResult AddProduct(ProductsView pr)
        {
            if(ModelState.IsValid)
            {
                Product p = new Product()
                {
                    name = pr.product.name,
                    imageurl = pr.product.imageurl,
                    description = pr.product.description,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    initial_quantity = pr.product.initial_quantity
                };
                _context.products.Add(p);
                _context.SaveChanges();
                return RedirectToAction("ProductShowcase");
            }
            return RedirectToAction("ProductShowcase");
        }
    }
}