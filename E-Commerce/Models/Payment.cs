using E_Commerce.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Payment
    {
		public int Id { get; set; }

		[ForeignKey("Customer")]
		public int CustomerId { get; set; }

		public Customer Customer { get; set; }

		[ForeignKey("Order")]
		public int OrderId { get; set; }

		public Order Order { get; set; }

		public string PaymentReference { get; set; }

		public PaymentStatus Status { get; set; }

		public decimal Amount { get; set; }

		public DateTime PaymentDate { get; set; }
	}
}
