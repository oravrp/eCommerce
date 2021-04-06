using System.Collections.Generic;

namespace ECommerce.Models.ViewModels
{
    public class CustomersView
    {
        public CustomersView()
        {
            customerlist = new List<Customer>();
        }
        public Customer customer { get; set; }
        public List<Customer> customerlist { get; set; }
    }
}