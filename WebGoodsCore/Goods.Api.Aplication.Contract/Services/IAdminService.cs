using Goods.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Contract.Services
{
    public interface IAdminService
    {
        Task<string> GetAdminName(int id);
        Task<IEnumerable<Admin>> GetAdminAll();
        Task<Admin> AddAmin(Admin admin);
    }
}
