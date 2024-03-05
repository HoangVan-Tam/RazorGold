using RazorGold.Application.DTOs.Common;
using RazorGold.Application.DTOs.Order;
using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.DTOs.Customer
{
    public class CustomerDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; } = Enumerable.Empty<OrderDto>();
    }
}
