using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class AdminEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<AdminEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Admins");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Id).IsRequired();
            entityTypeBuilder.Property(x => x.Name).IsRequired();

            //entityTypeBuilder.HasOne(x => x.Office).WithOne(x => x.Admin);

        }
    }
}
