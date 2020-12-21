using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class RoomAdnServicesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<RoomAndSerciceEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("RoomAndSercices");

            entityTypeBuilder.HasOne(x => x.Room).WithMany(x => x.RoomAndSercice).HasForeignKey(x => x.IdRomm);
            entityTypeBuilder.HasOne(x => x.Service).WithMany(x => x.RoomAndSercice).HasForeignKey(x => x.IdService);

            entityTypeBuilder.HasKey(x => new { x.IdRomm, x.IdService });
            entityTypeBuilder.Property(x => x.IdRomm).IsRequired();
            entityTypeBuilder.Property(x => x.IdService).IsRequired();

        }
    }
}
