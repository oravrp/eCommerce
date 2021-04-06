using System.Collections.Generic;

namespace ECommerce.Models.ViewModels
{
    public class OrdersView
    {
        public OrdersView()
        {
            orderlist = new List<Order>();
            productlist = new List<Product>();
            customerlist = new List<Customer>();
        }
        public Order order { get; set; }
        public List<Order> orderlist { get; set; }
        public List<Product> productlist { get; set; }
        public List<Customer> customerlist { get; set; }
        
        
    }
}