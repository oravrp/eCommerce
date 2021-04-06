using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Customer
    {
        [Key]
        public int customer_id {get; set;}
        [Required]
        public string name {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        public List<Order> orders {get; set;}
        public int DaysWithShop{
            get{
                DateTime a = created_at;
                DateTime now = DateTime.Now;
                TimeSpan ts = now-a;
                return Math.Abs(ts.Days);
            }
        }
        public Customer()
        {
            orders = new List<Order>();
        }
    }
}