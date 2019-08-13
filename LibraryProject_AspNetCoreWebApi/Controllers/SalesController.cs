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

        [HttpGet("{stor_id}/{ord_num}/{title_id}")]
        public ActionResult<string> Get(string stor_id, string ord_num, string title_id)
            {
            return Ok(_salesService.GetSale(stor_id, ord_num, title_id));
        }

        [HttpPost]
        public void Post([FromBody] Sales sale)
        {
            _salesService.AddSale(sale);
        }

        [HttpPut("{stor_id}/{ord_num}/{title_id}")]
        public void Put(string stor_id, string ord_num, string title_id, [FromBody]Sales sale)
        {
            _salesService.UpdateSale(sale);
        }

        [HttpDelete("{stor_id}/{ord_num}/{title_id}")]
        public void Delete(string stor_id, string ord_num, string title_id)
        {
            _salesService.DeleteSale(stor_id, ord_num, title_id);
        }
    }
}
