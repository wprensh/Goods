using Goods.Api.DataAccess.Contracts;
using Goods.Api.DataAccess.Contracts.Etities;
using Goods.Api.DataAccess.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Repository
{
    public class AdminRepository: IAdminRepository
    {
        private readonly IGoodsDBContext _goodsDBContext;

        public  AdminRepository(IGoodsDBContext goodsDBContext)
        {
            _goodsDBContext = goodsDBContext;
        }

        public async Task<AdminEntities> Add(AdminEntities element)
        {
            await _goodsDBContext.Admins.AddAsync(element);
            await _goodsDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<AdminEntities> DeleteAsync(int id)
        {
            var entity = await _goodsDBContext.Admins.SingleOrDefaultAsync(x=>x.Id == id);
             _goodsDBContext.Admins.Remove(entity);
            await _goodsDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<AdminEntities> Get(int id)
        {
            var Result = await _goodsDBContext.Admins.FirstOrDefaultAsync(x => x.Id == id);
            return Result;
        }

        public async Task<IEnumerable<AdminEntities>> GetAdminAll()
        {
            var entity = await _goodsDBContext.Admins.ToListAsync();

            return entity;
        }

        public async Task<IEnumerable<AdminEntities>> GetAll()
        {
            var entity = await _goodsDBContext.Admins.ToListAsync();

            return entity;
        }

        public async Task<AdminEntities> Update(int id,AdminEntities element)
        {
            var entity = await Get(id);
            entity.Name = element.Name;
            var Result = _goodsDBContext.Admins.Update(entity);
            await _goodsDBContext.SaveChangesAsync();
            return Result.Entity;
        }

        
    }
}
