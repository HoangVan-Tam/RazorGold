using RazorGold.Application.DTOs.Common;
using RazorGold.Application.DTOs.Product;
using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.DTOs.Order
{
    public class OrderDetailDto : BaseDto
    {
        public int ProductDetailId { get; set; }
        public int OrderId { get; set; }
        public int Qty { get; set; }
        public Decimal Total { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
