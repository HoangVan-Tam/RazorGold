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
    public class ProductDetail : BaseDomainEntitiy
    {
        public string ProductId { get; set; }
        public string ImageUrl { get;set; }
        public decimal Price { get; set; }
        public int Color { get; set; }
        public string Size { get; set; }
        public int Qty { get; set; }
        public Product Product { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; } = Enumerable.Empty<OrderDetail>();
    }
}
