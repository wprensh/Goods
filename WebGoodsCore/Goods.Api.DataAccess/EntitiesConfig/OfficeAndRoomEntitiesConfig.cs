using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class OfficeAndRoomEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<OfficesAndRoomEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("OfficessAndRooms");

            entityTypeBuilder.HasOne(x => x.Office).WithMany(x => x.OfficesAndRoom).HasForeignKey(x=>x.IdOffice);
            entityTypeBuilder.HasOne(x => x.Room).WithMany(x => x.OfficesAndRoom).HasForeignKey(x=>x.IdRoom);

            entityTypeBuilder.HasKey(x => new { x.IdOffice, x.IdRoom });
            entityTypeBuilder.Property(x => x.IdOffice).IsRequired();
            entityTypeBuilder.Property(x => x.IdRoom).IsRequired();

        }
    }
}
