using Goods.Api.DataAccess.Contracts.Etities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.EntitiesConfig
{
    public class BookingEntitiesConfig
    {
        public static void SetEntitiesBuilder(EntityTypeBuilder<BookingEntities> entityTypeBuilder)
        {

            entityTypeBuilder.ToTable("Bookings");
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.Id).IsRequired();
            entityTypeBuilder.Property(x => x.IdUser).IsRequired();
            entityTypeBuilder.Property(x => x.IdRoom).IsRequired();

            //entityTypeBuilder.HasOne(x => x.Office).WithOne(x => x.Booking);
            //entityTypeBuilder.HasOne(x => x.User).WithOne(x => x.Booking);

        }
    }
}
