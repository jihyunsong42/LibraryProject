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
    public class PublishersController : ControllerBase
    {
        private IPublishers _publishersService;
        public PublishersController(IPublishers publishersService)
        {
            _publishersService = publishersService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Publishers>> Get()
        {
            return Ok(_publishersService.GetPublishers());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return Ok(_publishersService.GetPublisher(id));
        }

        [HttpPost]
        public void Post([FromBody] Publishers publisher)
        {
            _publishersService.AddPublisher(publisher);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Publishers publisher)
        {
            _publishersService.UpdatePublisher(publisher);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _publishersService.DeletePublisher(id);
        }
    }
}
