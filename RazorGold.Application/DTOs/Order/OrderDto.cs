using RazorGold.Application.DTOs.Common;
using RazorGold.Application.DTOs.Customer;
using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.DTOs.Order
{
    public class OrderDto : BaseDto
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
        public CustomerDto CustomerDto { get; set; }
        public IEnumerable<OrderDetailDto> Details { get; set; }

        public OrderDto()
        {
            Total = Details.Sum(d => d.Total) + ShippingPrice;
            SubTotal = Details.Sum(d => d.Total);
        }
    }
}
