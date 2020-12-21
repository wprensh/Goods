using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
   public class UserEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateData { get; set; }

        //public virtual BookingEntities Booking { get; set; }
    }
}
