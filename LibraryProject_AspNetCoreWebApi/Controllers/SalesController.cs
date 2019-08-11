using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryProject_AspNetCoreWebApi.Models;
using LibraryProject_AspNetCoreWebApi.Data;
using LibraryProject_AspNetCoreWebApi.Services;

namespace LibraryProject_AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ISales _salesService;
        public SalesController(ISales salesService)
        {
            _salesService = salesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sales>> Get()
        {
            return Ok(_salesService.GetSales());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string stor_id, string ord_num, string title_id)
        {
            return Ok(_salesService.GetSale(stor_id, ord_num, title_id));
        }
    }
}
