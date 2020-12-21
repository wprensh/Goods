using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
    public class RoomAndSerciceEntities
    {
        public int IdRomm { get; set; }
        public int IdService { get; set; }
        public virtual RoomEntities Room { get; set; }
        public virtual ServiceEntities Service { get; set; }
    }
}
