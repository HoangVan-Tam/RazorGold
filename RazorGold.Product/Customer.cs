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
    public class Customer : BaseDomainEntitiy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public IEnumerable<Order> Orders { get; set; } = Enumerable.Empty<Order>();
    }
}
