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
    }
}
