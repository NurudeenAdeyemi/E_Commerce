using E_Commerce.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
       
        [Required(ErrorMessage = "Shipping address is required")]
        [StringLength(300)]
        public string ShippingAddress { get; set; }

        public decimal Total { get; set; }

        public string Orderreference { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }

        public Payment Payment { get; set; }

        public OrderStatus Status { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

        
    }
}
