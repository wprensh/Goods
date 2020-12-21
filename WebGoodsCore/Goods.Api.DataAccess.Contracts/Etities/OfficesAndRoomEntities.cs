using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
    public class OfficesAndRoomEntities
    {
        public int IdOffice { get; set; }
        public int IdRoom { get; set; }

        public virtual OfficesEntities Office { get; set; }

        public virtual RoomEntities  Room { get; set; }
    }
}
