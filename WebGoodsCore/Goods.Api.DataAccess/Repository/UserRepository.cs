using Goods.Api.DataAccess.Contracts;
using Goods.Api.DataAccess.Contracts.Etities;
using Goods.Api.DataAccess.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IGoodsDBContext _goodsDBContext;

        public UserRepository(IGoodsDBContext goodsDBContext)
        {
            _goodsDBContext = goodsDBContext;
        }
        public async Task<UserEntities> Add(UserEntities element)
        {
            await _goodsDBContext.Users.AddAsync(element);
            await _goodsDBContext.SaveChangesAsync();
            return element;
        }

        public async Task<UserEntities> DeleteAsync(int id)
        {
            var entity = await _goodsDBContext.Users.SingleOrDefaultAsync(x => x.Id == id);
            _goodsDBContext.Users.Remove(entity);
            await _goodsDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntities> Get(int id)
        {
            var Result = await _goodsDBContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            return Result;
        }

        public Task<IEnumerable<UserEntities>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntities> Update(int id, UserEntities element)
        {
            var entity = await Get(id);
            entity.Name = element.Name;
            var Result = _goodsDBContext.Users.Update(entity);
            await _goodsDBContext.SaveChangesAsync();
            return Result.Entity;
        }
    }
}
