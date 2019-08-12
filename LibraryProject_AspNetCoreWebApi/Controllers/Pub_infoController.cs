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
    public class Pub_infoController : ControllerBase
    {
        private IPub_info _pub_infoService;
        public Pub_infoController(IPub_info pub_infoService)
        {
            _pub_infoService = pub_infoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pub_info>> Get()
        {
            return Ok(_pub_infoService.GetPub_infos());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_pub_infoService.GetPub_info(id));
        }

        [HttpPost]
        public void Post([FromBody] Pub_info pub_info)
        {
            _pub_infoService.AddPub_info(pub_info);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Pub_info pub_info)
        {
            _pub_infoService.UpdatePub_info(pub_info);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _pub_infoService.DeletePub_info(id);
        }
    }
}
