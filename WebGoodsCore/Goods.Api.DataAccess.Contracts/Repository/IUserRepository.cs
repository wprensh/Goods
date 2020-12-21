using Goods.Api.DataAccess.Contracts.Etities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Contracts.Repository
{
    public interface IUserRepository : IRepository<UserEntities>
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<UserEntities>> GetAll();
        Task<UserEntities> Get(int id);
        Task<UserEntities> DeleteAsync(int id);
        Task<UserEntities> Update(int id, UserEntities element);
        Task<UserEntities> Add(UserEntities element);
    }
}
