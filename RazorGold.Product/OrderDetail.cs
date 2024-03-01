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
    public class OrderDetail : BaseDomainEntitiy
    {
        public int ProductDetailId { get;set; }
        public int OrderId { get; set; }
        public int Qty { get; set; }
        public Decimal Total { get; set; }
        public Order Order { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
