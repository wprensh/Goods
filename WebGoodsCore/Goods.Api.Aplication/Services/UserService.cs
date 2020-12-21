using Goods.Api.Aplication.Contract.Services;
using Goods.Api.DataAccess.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Services
{
    public class UserService : IUserService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IAdminRepository adminRepository, IUserRepository userRepository)
        {
            _adminRepository = adminRepository;
            _userRepository = userRepository;
        }


        public async Task<string> Get(int id)
        {
            var entities = await _adminRepository.Get(id);
            return entities.Name;
        }

        public async Task GetUserName(int id) 
        {
            var AdminName = await _adminRepository.Get(id);
        }
    }
}
