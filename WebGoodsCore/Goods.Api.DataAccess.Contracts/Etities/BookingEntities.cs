using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
    public class BookingEntities
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CrearteDate { get; set; }
        public int IdOffice { get; set; }
        public bool RenWorkSpace { get; set; }
        public int? IdRoom { get; set; }

        //public virtual UserEntities User { get; set; }

        //public virtual OfficesEntities Office { get; set; }


    }
}
