using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGold.Application.Persistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T>Get(int id);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(int id);
    }
}
