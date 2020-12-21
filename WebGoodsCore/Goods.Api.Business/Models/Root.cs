using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Goods.Api.Business.Models
{
    public class Root
    {
        public string Message { get; set; }
        public Global Global { get; set; }
        public List<Countries> Countries { get; set; }
        public DateTime Date { get; set; }
    }
}
