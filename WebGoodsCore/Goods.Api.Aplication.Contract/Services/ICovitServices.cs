using Goods.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.Aplication.Contract.Services
{
    public interface ICovitServices
    {
        Task<Root> EmployeeSearch();
    }
}
