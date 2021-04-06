using System.Collections.Generic;

namespace ECommerce.Models.ViewModels
{
    public class DashboardView
    {
        public string prodsearchkeyword {get; set;}
        public List<Product> productlist  {get; set;}
        public List<Order> orderlist  {get; set;}
        public List<Customer> customerlist  {get; set;}
        public DashboardView ()
        {
            productlist = new List<Product>();
            orderlist = new List<Order>();
            customerlist = new List<Customer>();
        }
    }
}