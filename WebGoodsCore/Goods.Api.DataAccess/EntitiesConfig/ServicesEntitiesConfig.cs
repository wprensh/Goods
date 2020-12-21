using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
   public class ServicesEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<ServiceEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Services");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Id).IsRequired();
            entityTypeBuilder.Property(x => x.Name).IsRequired();



        }
    }
}
