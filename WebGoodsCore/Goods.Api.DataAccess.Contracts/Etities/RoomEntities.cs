using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
    public class RoomEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<OfficesAndRoomEntities> OfficesAndRoom { get; set; }
        public virtual ICollection<RoomAndSerciceEntities> RoomAndSercice { get; set; }


    }
}
