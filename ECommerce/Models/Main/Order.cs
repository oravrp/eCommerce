using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Order
    {
        [Key]
        public int order_id{get; set;}
        public int product_id{get; set;}
        public int customer_id {get; set;}
        public int item_count {get; set;}
        public Customer customer {get; set;}
        public Product product {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
    }
}