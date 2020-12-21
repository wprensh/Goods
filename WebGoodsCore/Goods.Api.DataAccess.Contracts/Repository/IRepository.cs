using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Contracts.Repository
{
    public interface IRepository<T> where T : class 
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> DeleteAsync(int id);
        Task<T> Update(int id,T element);
        Task<T> Add(T element);
    }
}
