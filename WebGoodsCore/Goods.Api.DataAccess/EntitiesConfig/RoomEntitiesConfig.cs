using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class RoomEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<RoomEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Rooms");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Id).IsRequired();
            entityTypeBuilder.Property(x => x.Name).IsRequired();



        }
    }
}
