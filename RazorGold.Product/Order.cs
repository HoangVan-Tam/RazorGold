using RazorGold.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Domain
{
    public class Order : BaseDomainEntitiy
    {
        public int CustomerId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal ShippingPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Note { get; set; }
        public string PaymentStatus { get; set; }
        public string ShippingStatus { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }

        public Order()
        {
            Total = Details.Sum(d => d.Total) + ShippingPrice;
            SubTotal = Details.Sum(d => d.Total);
        }
    }
}
