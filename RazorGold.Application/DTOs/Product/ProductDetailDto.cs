using RazorGold.Application.DTOs.Common;
using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.DTOs.Product
{
    public class ProductDetailDto : BaseDto
    {
        public string ProductId { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Color { get; set; }
        public string Size { get; set; }
        public int Qty { get; set; }
    }
}
