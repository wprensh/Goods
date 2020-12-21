using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Contract.Services
{
    public interface IUserService
    {
        Task<string> Get(int id);
        Task GetUserName(int id);
    }
}
