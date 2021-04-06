using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int product_id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        [DataType(DataType.ImageUrl)]
        public string imageurl {get; set;}
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string description {get; set;}
        [Range(1, 100000)]
        public int initial_quantity {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        public List<Order> orders {get; set;}
        public Product()
        {
            orders = new List<Order>();
        }
    }
}