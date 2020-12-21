using Goods.Api.Aplication.Contract.Services;
using Goods.Api.Business.Models;
using Goods.Api.DataAccess.Contracts.Repository;
using Goods.Api.DataAccess.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<string> GetAdminName(int id)
        {
            var entities =  await _adminRepository.Get(id);
            return entities.Name;           
        }

        public async Task<IEnumerable<Admin>> GetAdminAll()
        {
            var entities = await _adminRepository.GetAdminAll();
            return entities.Select(AdminMapper.Map);
        }

        public async Task<Admin> AddAmin(Admin admin)
        {
            var entities = await _adminRepository.Add(AdminMapper.Map(admin));
            return AdminMapper.Map(entities);
        }
    }
}
