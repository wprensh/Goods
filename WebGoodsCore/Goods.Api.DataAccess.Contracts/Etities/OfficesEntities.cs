using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
   public class OfficesEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addess { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int IdAdmin { get; set; }
        public bool HasIndividualWorkSpace { get; set; }
        public int NumberWorkSpace { get; set; }
        public decimal ProceWorkSpaceDetail { get; set; }
        public decimal ProceWorkSpaceMothly { get; set; }

        //public virtual AdminEntities Admin { get; set; }

        public virtual ICollection<OfficesAndRoomEntities> OfficesAndRoom { get; set; }

        //public virtual BookingEntities Booking { get; set; }
    }
}
