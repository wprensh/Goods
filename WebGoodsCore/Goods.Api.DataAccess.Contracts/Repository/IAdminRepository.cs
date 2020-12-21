using Goods.Api.DataAccess.Contracts.Etities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Contracts.Repository
{
    public interface IAdminRepository : IRepository<AdminEntities>
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<AdminEntities>> GetAdminAll();
        Task<AdminEntities> Get(int id);
        Task<AdminEntities> DeleteAsync(int id);
        Task<AdminEntities> Update(int id, AdminEntities element);
        Task<AdminEntities> Add(AdminEntities element);
    }
}
