using System;
using System.Collections.Generic;
using System.Text;

namespace Goods.Api.DataAccess.Contracts.Etities
{
   public class AdminEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        //public virtual OfficesEntities Office { get; set; }
    }
}
