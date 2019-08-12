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
    public class StoresController : ControllerBase
    {
        private IStores _storesService;
        public StoresController(IStores storesService)
        {
            _storesService = storesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Stores>> Get()
        {
            return Ok(_storesService.GetStores());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_storesService.GetStore(id));
        }

        [HttpPost]
        public void Post([FromBody] Stores store)
        {
            _storesService.AddStore(store);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Stores store)
        {
            _storesService.UpdateStore(store);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _storesService.DeleteStore(id);
        }
    }
}
