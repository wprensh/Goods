using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Goods.Api.Aplication.Contract.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Goods.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaCovitController : ControllerBase
    {

        private ICovitServices _covitServices;

        public PruebaCovitController(ICovitServices covitServices)
        {
            _covitServices = covitServices;
        }
        // GET: api/<PruebaCovitController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpPost]
        public async Task<IActionResult> GetRoot()
        {
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();

            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();

            var contactName = Request.Form["columns[2][search][value]"].FirstOrDefault();
            var country = Request.Form["columns[1][search][value]"].FirstOrDefault();


            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            var resultName = await _covitServices.EmployeeSearch();
            var result = (from s in resultName.Countries select new { s.Country, s.CountryCode, s.Slug });


            if (!string.IsNullOrEmpty(contactName))
            {
                result = result.Where(a => a.Country.ToLower().Contains(contactName.ToLower())).ToList();
            }
            recordsTotal = result.Count();
            var data = result.Skip(skip).Take(pageSize).ToList();

            var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return  Ok(jsonData);
        }





        // GET api/<PruebaCovitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PruebaCovitController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<PruebaCovitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PruebaCovitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
