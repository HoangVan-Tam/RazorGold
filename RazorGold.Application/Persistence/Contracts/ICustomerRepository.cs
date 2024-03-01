using RazorGold.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.Persistence.Contracts
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
