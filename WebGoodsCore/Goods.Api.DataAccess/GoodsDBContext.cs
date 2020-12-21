using Goods.Api.DataAccess.Contracts;
using Goods.Api.DataAccess.Contracts.Etities;
using Goods.Api.DataAccess.EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess
{
    public class GoodsDBContext : DbContext, IGoodsDBContext
    {
        public GoodsDBContext(DbContextOptions options) : base(options) { 
            
        }
        public GoodsDBContext()
        {

        }
        public DbSet<UserEntities> Users { get; set; }
        public DbSet<AdminEntities> Admins { get; set; }
        public DbSet<BookingEntities> Bookings { get; set; }
        public DbSet<OfficesEntities> Offices { get; set; }
        public DbSet<OfficesAndRoomEntities> OfficeAndRooms { get; set; }
        public DbSet<RoomAndSerciceEntities> RoomAndSercices { get; set; }
        public DbSet<RoomEntities> Rooms { get; set; }
        public DbSet<ServiceEntities> Services { get; set; }
        // Specify DbSet properties etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add your own configuration here
            AdminEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<AdminEntities>());
            BookingEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<BookingEntities>());
            OfficeAndRoomEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<OfficesAndRoomEntities>());
            OfficeEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<OfficesEntities>());
            RoomAdnServicesConfig.SetEntitiesBuilder(modelBuilder.Entity<RoomAndSerciceEntities>());
            RoomEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<RoomEntities>());
            ServicesEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<ServiceEntities>());
            UserEntitiesConfig.SetEntitiesBuilder(modelBuilder.Entity<UserEntities>());

            base.OnModelCreating(modelBuilder);

          
        }
    }
}
