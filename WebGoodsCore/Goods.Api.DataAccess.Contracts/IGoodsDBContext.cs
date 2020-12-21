using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Goods.Api.DataAccess.Contracts
{
    public interface IGoodsDBContext
    {
         DbSet<UserEntities> Users { get; set; }
         DbSet<AdminEntities> Admins { get; set; }
         DbSet<BookingEntities> Bookings { get; set; }
         DbSet<OfficesEntities> Offices { get; set; }
         DbSet<OfficesAndRoomEntities> OfficeAndRooms { get; set; }
         DbSet<RoomAndSerciceEntities> RoomAndSercices { get; set; }
         DbSet<RoomEntities> Rooms { get; set; }
         DbSet<ServiceEntities> Services { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);

        EntityEntry Update(object entites);
    }
}
