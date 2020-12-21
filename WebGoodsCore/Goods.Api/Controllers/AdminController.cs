using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Goods.Api.Aplication.Contract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Goods.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var resultName = await _adminService.GetAdminName(id);
            return Ok(resultName);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var resultName = await _adminService.GetAdminAll();
            return Ok(resultName);
        }
    }
}
