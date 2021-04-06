using System.Collections.Generic;

namespace ECommerce.Models.ViewModels
{
    public class ProductsView
    {
        public string prodsearchkeyword {get; set;}
        public ProductsView()
        {
            productlist = new List<Product>();
        }
        public Product product { get; set; }
        public List<Product> productlist { get; set; }
        
    }
}