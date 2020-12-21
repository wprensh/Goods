using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
    public class ServiceEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<RoomAndSerciceEntities> RoomAndSercice { get; set; }

    }
}
