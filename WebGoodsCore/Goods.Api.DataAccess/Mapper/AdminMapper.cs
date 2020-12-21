using Goods.Api.Business.Models;
using Goods.Api.DataAccess.Contracts.Etities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Mapper
{
    public static class AdminMapper
    {
        public static AdminEntities Map(Admin admin) 
        {
            return new AdminEntities()
            {

                Id = admin.Id,
                Name = admin.Name,
                Email = admin.Email,
                SurName = admin.SurName

            };
        }

        public static Admin Map(AdminEntities entities)
        {
            return new Admin()
            {

                Id = entities.Id,
                Name = entities.Name,
                Email = entities.Email,
                SurName = entities.SurName

            };
        }
    }
}
