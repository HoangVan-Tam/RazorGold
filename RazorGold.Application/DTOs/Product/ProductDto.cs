using RazorGold.Application.DTOs.Common;
using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public IEnumerable<ProductDetail> ProductDetails { get; set; }
    }
}
