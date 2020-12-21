using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class OfficeEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<OfficesEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Officess");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Id).IsRequired();
            entityTypeBuilder.Property(x => x.Name).IsRequired();
            entityTypeBuilder.Property(x => x.IdAdmin).IsRequired();

            //entityTypeBuilder.HasOne(x => x.Admin).WithOne(x => x.Office);
            //entityTypeBuilder.HasOne(x => x.Booking).WithOne(x => x.Office);


        }
    }
}
